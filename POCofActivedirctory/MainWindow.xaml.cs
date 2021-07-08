using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.DirectoryServices;
using System.Collections;
using System.DirectoryServices.AccountManagement;
using System.Security.Principal;

namespace POCofActivedirctory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public enum ActionTypes
        {
            Filter,
            Save,
            None,
        }
        public static PrincipalContext insPrincipalContext = new PrincipalContext(ContextType.Machine);
        public static GroupPrincipal SelectedGroup;
        private void ListGroups()
        {
            GroupPrincipal insGroupPrincipal = new GroupPrincipal(insPrincipalContext);
            insGroupPrincipal.Name = "*";
            SearchGroups(insGroupPrincipal);
        }
        private void SearchGroups(GroupPrincipal parGroupPrincipal)
        {
            lstGroup.Items.Clear();
            PrincipalSearcher insPrincipalSearcher = new PrincipalSearcher();
            insPrincipalSearcher.QueryFilter = parGroupPrincipal;
            PrincipalSearchResult<Principal> results = insPrincipalSearcher.FindAll();
            foreach (Principal p in results)
            {
                lstGroup.Items.Add(p);


            }


        }
        private void ListUsers()
        {
            UserPrincipal insUserPrincipal = new UserPrincipal(insPrincipalContext);
            insUserPrincipal.Name = "*";
            SearchUsers(insUserPrincipal);
        }
        private void SearchUsers(UserPrincipal parUserPrincipal)
        {

           
            PrincipalSearcher insPrincipalSearcher = new PrincipalSearcher();
            insPrincipalSearcher.QueryFilter = parUserPrincipal;
            PrincipalSearchResult<Principal> results = insPrincipalSearcher.FindAll();
            foreach (Principal p in results)
            {
                lstUser.Items.Add(p.SamAccountName);
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ListUsers();
            ListGroups();
            DirectoryEntry localMachine = new DirectoryEntry("WinNT://" + Environment.MachineName);
            DirectoryEntry admGroup = localMachine.Children.Find("administrators", "group");
            // admGroup.Username = "Administratore";
            object members = admGroup.Invoke("members", null);
            // List<string> lst = new List<string>();
            foreach (object groupMember in (IEnumerable)members)
            {
                DirectoryEntry member = new DirectoryEntry(groupMember);
               // lstUser.Items.Add (member.Name);
            }
           // lstGroup.ItemsSource = EmpData;//.ToList<EmployeeData>();
            //lstGroup.DataContext = EmpData.ToList();//.ToList<EmployeeData>();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            UserPrincipal insUserPrincipal = new UserPrincipal(insPrincipalContext, txtUserName.Text, txtpwd.Password, true);
            try
            {
                insUserPrincipal.DisplayName =txtUserName.Text;
                insUserPrincipal.Description = "This User For Test";
                insUserPrincipal.Save();
                insUserPrincipal.Dispose();
                MessageBox.Show("User created.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ListUsers();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            string UserName = WindowsIdentity.GetCurrent().Name.Split('\\')[1];

            if (lstUser.SelectedItem == null)
            {
                MessageBox.Show("Please select a user");
                return;
            }
            // UserManagment emp = (UserManagment)lstUser.SelectedItem;
            UserPrincipal insUserPrincipal = new UserPrincipal(insPrincipalContext);
            insUserPrincipal.Name = lstUser.SelectedItem.ToString();
            PrincipalSearcher insPrincipalSearcher = new PrincipalSearcher();
            insPrincipalSearcher.QueryFilter = insUserPrincipal;
            Principal results = insPrincipalSearcher.FindOne();
            if (results != null)
            {
                if (UserName != results.SamAccountName)
                {
                    try
                    {
                        results.Delete();
                        
                        
                        results.Dispose();
                        lstUser.Items.Clear();
                        MessageBox.Show("User deleted.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    ListUsers();
                }
                else
                { MessageBox.Show("Currently User Logined . You can't delete this user"); }
            }
            else
            { MessageBox.Show("User is not exist"); }
        }
        public void GroupProperties(object propertyItem, ActionTypes actionType)
        {
            object GroupObject = new object();
            if (propertyItem is List<Principal>)
            {
                GroupObject = ((List<Principal>)propertyItem).ToArray();
            }
            else
            {
                GroupObject = propertyItem;
            }


        }
        private void gAdd_Click(object sender, RoutedEventArgs e)
        {
            GroupPrincipal insGroupPrincipal = new GroupPrincipal(insPrincipalContext, txtgname.Text);
            // frmProperties insFrmProperties = new frmProperties(insGroupPrincipal, ActionTypes.Save);
            // insFrmProperties.ShowDialog();
            GroupProperties(insGroupPrincipal, ActionTypes.Save);

            try
            {
                //insGroupPrincipal.DisplayName = "GroupTest";
                //insGroupPrincipal.Name = "G1";
                //insGroupPrincipal.SamAccountName = "G1";
                //insGroupPrincipal.UserPrincipalName = "G1";
                //UserModule.Groupsright NewGroup = new Groupsright();
              
               // UserManagmentdatacontext.SubmitChanges();
                insGroupPrincipal.Save();
                insGroupPrincipal.Dispose();
                MessageBox.Show("Group created.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ListGroups();
        }

        private void gDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lstGroup.SelectedItem == null)
            {
                MessageBox.Show("Please select a group");
                return;
            }
            GroupPrincipal insGroupPrincipal = (GroupPrincipal)lstGroup.SelectedItem;
            try
            {
                insGroupPrincipal.Delete();
                insGroupPrincipal.Dispose();
                lstGroup.Items.Clear();
                MessageBox.Show("Group deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ListGroups();
        }
        
     
        private void lstGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            lstGroupUser.Items.Clear();
            lstNotconnectgroupuser.Items.Clear();
            if (lstGroup.SelectedItem == null)
            {
                MessageBox.Show("Please select a group");
                return;
            }

            SelectedGroup = (GroupPrincipal)lstGroup.SelectedItem;

             List<Principal> insListPrincipal = new List<Principal>();
             foreach (Principal p in SelectedGroup.Members)
             {
                 lstGroupUser.Items.Add(p.SamAccountName);
             }

             txtgname.Text = SelectedGroup.Name;
            txtgname.IsEnabled = false;
            UserPrincipal insUserPrincipal = new UserPrincipal(insPrincipalContext);
            insUserPrincipal.Name = "*";
           // List<UserManagment> emp1 = GetUsernotinGroup(null, insGroupPrincipal, insUserPrincipal);
           // lstNotconnectgroupuser.ItemsSource = emp1;
           // lstNotconnectgroupuser.DataContext = emp1;
            PrincipalSearcher insPrincipalSearcher = new PrincipalSearcher();
            insPrincipalSearcher.QueryFilter = insUserPrincipal;
            PrincipalSearchResult<Principal> results = insPrincipalSearcher.FindAll();
            int t = 0;
            foreach (Principal p in results)
            {
                t = 0;
                foreach (string s in lstGroupUser.Items)
                {
                    if (s == p.SamAccountName)
                    {
                        t = 1;
                        break;

                    }
                    else
                    { t = 0; }
                    
                }
                if (t == 0)
                    lstNotconnectgroupuser.Items.Add(p.SamAccountName);

            }

            lst = lstGroup;
           
        }
        public static ListBox lst;
        public static void AddUserIntoGroup(GroupPrincipal group, PrincipalContext insPrincipalContext,string UserName, string strgroupname)
        {

            UserPrincipal insUserPrincipal = new UserPrincipal(insPrincipalContext);
            insUserPrincipal.Name = UserName;
            PrincipalSearcher insPrincipalSearcher = new PrincipalSearcher();
            insPrincipalSearcher.QueryFilter = insUserPrincipal;
            Principal results = insPrincipalSearcher.FindOne();



            //UserPrincipal insUserPrincipal = (UserPrincipal)lstNotconnectgroupuser.SelectedItem;

            // GroupPrincipal group = (GroupPrincipal)lstGroup.SelectedItem;
            //frmProperties insFrmProperties = new frmProperties(group, ActionTypes.Save);
            //insFrmProperties.ShowDialog();
            //  if (insFrmProperties.DialogResult == DialogResult.OK)
            // {
            try
            {
                GroupPrincipal groupPrincipal = GroupPrincipal.FindByIdentity(insPrincipalContext, group.Name);
                if (groupPrincipal == null)
                {
                    MessageBox.Show("Group not found.");
                    return;
                }
                if (groupPrincipal.Members.Contains(insPrincipalContext, IdentityType.SamAccountName, results.SamAccountName))
                {
                    MessageBox.Show(insUserPrincipal.Name + " is already a member of group " + group.Name);
                    return;
                }

                groupPrincipal.Members.Add(results);
                groupPrincipal.Save();
                SelectedGroup = (GroupPrincipal)lst.SelectedItem;
                GroupPrincipal insGroupPrincipal = new GroupPrincipal(insPrincipalContext);
                insGroupPrincipal.Name = strgroupname;
                PrincipalSearcher insPrincipalSearcherg = new PrincipalSearcher();
                insPrincipalSearcher.QueryFilter = insGroupPrincipal;
                PrincipalSearchResult<Principal> resultsg = insPrincipalSearcher.FindAll();
                //foreach (Principal p in resultsg)
                //{
                //    lst.Items.Add(p);


                //}
                lst.SelectedItem = SelectedGroup;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void RemoveFromGroup_Click(object sender, RoutedEventArgs e)
        {
            string UserName = (string)lstGroupUser.SelectedItem;
            UserPrincipal insUserPrincipal = new UserPrincipal(insPrincipalContext);
            insUserPrincipal.Name = UserName;
            PrincipalSearcher insPrincipalSearcher = new PrincipalSearcher();
            insPrincipalSearcher.QueryFilter = insUserPrincipal;
            Principal results = insPrincipalSearcher.FindOne();
            try
            {
                GroupPrincipal groupPrincipal = GroupPrincipal.FindByIdentity(insPrincipalContext, SelectedGroup.Name);
                if (groupPrincipal == null)
                {
                    MessageBox.Show("Group not found.");
                    return;
                }
                groupPrincipal.Members.Remove(results);
                groupPrincipal.Save();
                SelectedGroup = (GroupPrincipal)lst.SelectedItem;
                GroupPrincipal insGroupPrincipal = new GroupPrincipal(insPrincipalContext);
                insGroupPrincipal.Name = "*";
                PrincipalSearcher insPrincipalSearcherg = new PrincipalSearcher();
                insPrincipalSearcher.QueryFilter = insGroupPrincipal;
                PrincipalSearchResult<Principal> resultsg = insPrincipalSearcher.FindAll();
                lst.SelectedItem = SelectedGroup;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

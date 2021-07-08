# AllActiveDirectiveWPF

Introduction
Windows Active directry Managment With Darag and droap list box.

Building the Sample
You have the permision who can run the applicaion with windows active directry accesses permision defualt Administrator.

Description

This application shows the how to access the windows active direcotry and you can use acording to ypur requrment.

in this application you have followig functionality :-

1.List of the Cuurent active directory user's.

2.You can create new the Windows User.

3. You can delete the windows User.

4.You can manage the user with diffrence groups.

5.You can assign the user in to the goroup and remove from group by the simpale drag and droap opration.

 etc.

In this application you can find the solution for drag and droap functionality to One listbox to another list box.

 Please followinf the snapshot its more helpful for you

 this is the user tab wich is showing the all user's of Current windows active directory.



Second image showing Group Tab .

In this tab you can assign the groups for user then user behave according to the group.



 

This is the some declaration code these basic for the start of the application, with use of this you can access the Windows active directory.

 

C#
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
             PrincipalSearchResult results = insPrincipalSearcher.FindAll(); 
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
Source Code Files
Please download the code and full project from this link 
http://code.msdn.microsoft.com/Active-directory-Opration-ecb1c752/file/113990/5/All%20Active%20directory%20Opration%20C%23%20WPF%20List%20box.zip
More Information
If you have any additional information you can mail me info@jbko.in or prmdpandit@gmail.com.

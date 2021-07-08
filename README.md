  
<h1>Introduction</h1>
<p><em>Windows Active directry Managment With Darag and droap list box.</em></p>
<h1><span>Building the Sample</span></h1>
<p><em>You have the permision who can run the applicaion with windows active directry accesses permision defualt Administrator.</em></p>
<p><span style="font-size:20px; font-weight:bold">Description</span></p>
<p><em>This application shows the how to access the windows active direcotry and you can use acording to ypur requrment.</em></p>
<p><em>in this application you have followig functionality :-</em></p>
<p>1.List of the Cuurent active directory user's.</p>
<p>2.You can create new the Windows User.</p>
<p>3. You can delete the windows User.</p>
<p>4.You can manage the user with diffrence groups.</p>
<p>5.You can assign the user in to the goroup and remove from group by the simpale drag and droap opration.</p>
<p>&nbsp;</p>
<p>etc.</p>
<p><em>In this application you can find the solution for drag and droap functionality to One listbox to another list box.</em></p>
<p><em><br>
</em></p>
<p><em>Please followinf the snapshot its more helpful for you</em></p>
<p>&nbsp;</p>
<p><em>this is the user tab wich is showing the all user's of Current windows active directory.</em></p>
<p><em><img id="113988" src="description/UserTab.png" alt="" width="822" height="454"></em></p>
<p>Second image showing Group Tab .</p>
<p>In this tab you can assign the groups for user then user behave according to the group.</p>
<p><img id="113989" src="description/GroupTab.png" alt="" width="822" height="639"></p>
<p>&nbsp;</p>
<p>This is the some declaration code these basic for the start of the application, with use of this you can access the Windows active directory.</p>
<p>&nbsp;</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden"> public static PrincipalContext insPrincipalContext = new PrincipalContext(ContextType.Machine);
        public static GroupPrincipal SelectedGroup;
        private void ListGroups()
        {
            GroupPrincipal insGroupPrincipal = new GroupPrincipal(insPrincipalContext);
            insGroupPrincipal.Name = &quot;*&quot;;
            SearchGroups(insGroupPrincipal);
        }
        private void SearchGroups(GroupPrincipal parGroupPrincipal)
        {
            lstGroup.Items.Clear();
            PrincipalSearcher insPrincipalSearcher = new PrincipalSearcher();
            insPrincipalSearcher.QueryFilter = parGroupPrincipal;
            PrincipalSearchResult&lt;Principal&gt; results = insPrincipalSearcher.FindAll();
            foreach (Principal p in results)
            {
                lstGroup.Items.Add(p);


            }


        }
        private void ListUsers()
        {
            UserPrincipal insUserPrincipal = new UserPrincipal(insPrincipalContext);
            insUserPrincipal.Name = &quot;*&quot;;
            SearchUsers(insUserPrincipal);
        }</pre>
<div class="preview">
<pre class="csharp">&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">static</span>&nbsp;PrincipalContext&nbsp;insPrincipalContext&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;PrincipalContext(ContextType.Machine);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">static</span>&nbsp;GroupPrincipal&nbsp;SelectedGroup;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">private</span>&nbsp;<span class="cs__keyword">void</span>&nbsp;ListGroups()&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;GroupPrincipal&nbsp;insGroupPrincipal&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;GroupPrincipal(insPrincipalContext);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;insGroupPrincipal.Name&nbsp;=&nbsp;<span class="cs__string">&quot;*&quot;</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SearchGroups(insGroupPrincipal);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">private</span>&nbsp;<span class="cs__keyword">void</span>&nbsp;SearchGroups(GroupPrincipal&nbsp;parGroupPrincipal)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;lstGroup.Items.Clear();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;PrincipalSearcher&nbsp;insPrincipalSearcher&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;PrincipalSearcher();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;insPrincipalSearcher.QueryFilter&nbsp;=&nbsp;parGroupPrincipal;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;PrincipalSearchResult&lt;Principal&gt;&nbsp;results&nbsp;=&nbsp;insPrincipalSearcher.FindAll();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">foreach</span>&nbsp;(Principal&nbsp;p&nbsp;<span class="cs__keyword">in</span>&nbsp;results)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;lstGroup.Items.Add(p);&nbsp;
&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">private</span>&nbsp;<span class="cs__keyword">void</span>&nbsp;ListUsers()&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;UserPrincipal&nbsp;insUserPrincipal&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;UserPrincipal(insPrincipalContext);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;insUserPrincipal.Name&nbsp;=&nbsp;<span class="cs__string">&quot;*&quot;</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SearchUsers(insUserPrincipal);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}</pre>
</div>
</div>
</div>
<h1><span>Source Code Files</span></h1>
<ul>
<li><em>source code file name #1 - summary for this source code file.</em> </li><li><em><em>source code file name #2 - summary for this source code file.</em></em>
</li></ul>
<h1>More Information</h1>
<p><em>If you have any additional information you can mail me prmdpandit@gmail.com.</em></p>

</div>


    </div>
</body>
</html>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
    <head><link rel="stylesheet" type="text/css" href="description/Combined.css,0:HeaderFooterSprite,0:Header.NonMtps,1:LinkList;/Areas/Centers/Themes/StandardDevCenter/Content:0,/Areas/Epx/Themes/Base/Content:1&amp;amp;hashKey=9DC1BBE1613B3277EDB1CD608DD6B172" xmlns="http://www.w3.org/1999/xhtml" />
<link type="text/css" rel="stylesheet" xmlns="http://www.w3.org/1999/xhtml" />
<link rel="stylesheet" type="text/css" href="description/adcf341d-3f1e-4a69-8c58-f7a53ffcf1bdCombined.css,0:HeaderFooterSprite,0:Footer.NonMtps,1:LinkList;/Areas/Centers/Themes/StandardDevCenter/Content:0,/Areas/Epx/Themes/Base/Content:1&amp;amp;hashKey=400B4048FC6DD81C6C2705AF12442ECA" xmlns="http://www.w3.org/1999/xhtml" />
<link type="text/css" rel="stylesheet" xmlns="http://www.w3.org/1999/xhtml" />

        
<body>
    <div id="offlineDescription">
        <h1>All Active directory Operation C#.net WPF List box</h1>
        <br/>
        <div id="projectInfo">
            <div class="section">
                    <div class="itemBarLong tagsContainer">
                        <label for="Technologies">Technologies</label>
                        <div id="Technologies">
                            C#, WPF, Active Directory, XAML, .NET Framework 3.5 SP1, Windows General
                        </div>
                    </div>
                    <div class="itemBarLong tagsContainer">
                        <label for="Topics">Topics</label>
                        <div id="Topics">
                            Active Directory, Drag and Drop, ListBox, System.Director<wbr />yServices, System.Director<wbr />yServices.Accou<wbr />ntManagement;, System.Security<wbr />.Principal, GroupPrincipal, PrincipalContex<wbr />t, UserPrincipal
                        </div>
                    </div>
                <div class="itemBarLong">
                    <label for="Platforms">Platforms</label>
                    <div id="Platforms">
                        Desktop
                    </div>
                </div>
                <div class="itemBarLong">
                    <label for="Requirements">Requirements</label>
                    <div id="Requirements">
                        
                    </div>
                </div>
                <div class="itemBar">
                    <label for="LastUpdated">Primary language</label>
                    <div id="LastUpdated">en-US</div>
                </div>
                <div class="itemBar">
                    <label for="LastUpdated">Updated</label>
                    <div id="LastUpdated">9/30/2014</div>
                </div>
                <div class="itemBarLong">
                    <label for="License">License</label>
                    <div id="License">
                        <a href="license.rtf">MS-LPL</a></div>
                </div>
                <div class="itemBar">
                    <div class="viewonlinecont">
                        <a data-link="online" href="http://code.msdn.microsoft.com/Active-directory-Opration-ecb1c752">View this sample online</a>
                    </div>
                </div>
            </div>
        </div>
        
                   
<script type="text/javascript">
    function initializePage() {
        var otherTabClass = 'otherTab';
        var hiddenPreClass = 'hidden';

        var htmlDecode = function(encodedData) {
            var decodedData = "";
            if (encodedData) {
                var div = document.createElement('div');
                div.innerHTML = encodedData;
                decodedData = div.firstChild.nodeValue.replace( /\\r\\n/ig , '\r\n');
            }
            return decodedData;
        };
                
        Galleries.iterateElem(Galleries.findElem(null, 'div', 'scriptcode'), function (index, scriptBlock) {
            var titleElem = Galleries.findElem(scriptBlock, 'div', 'title')[0];
            var labelElems = Galleries.findElem(titleElem, 'span');
            if (labelElems.length == 0) {
                labelElems = titleElem;
            }
            var languageSpans = Galleries.findElem(scriptBlock, 'span', 'hidden');
            var pres = Galleries.findElem(scriptBlock, 'pre');
            if (languageSpans.length > 0 && pres.length > 1) {
                Galleries.iterateElem(labelElems, function(index, elem) {
                    var codePre = pres[index];
                    var labelSpan = elem;
                    var languageSpan = languageSpans[index];
                            
                    elem.code = codePre.innerHTML.replace( /(\r(\n)?)|((\r)?\n)/ig , '\\r\\n');
                            
                    codePre.className = codePre.className.replace(hiddenPreClass, '');
                            
                    languageSpan.parentNode.removeChild(languageSpan);
                });

                pres = Galleries.findElem(scriptBlock, 'pre');
                Galleries.iterateElem(labelElems, function(index, elem) {
                    var codePre = pres[index];
                    var labelSpan = elem;
                    if (index == 0) {
                        scriptBlock.activeTab = 0;
                    }
                    else {
                        labelSpan.className += otherTabClass;
                        codePre.className += hiddenPreClass;
                    }
                    Galleries.attachEventHandler(labelSpan, 'click', function(e) {
                        var activeTab = scriptBlock.activeTab;
                        labelElems[activeTab].className += otherTabClass;
                        pres[activeTab].className += hiddenPreClass;

                        codePre.className = codePre.className.replace(hiddenPreClass, '');
                        labelSpan.className = labelSpan.className.replace(otherTabClass, '');
                        scriptBlock.activeTab = index;
                    });
                });

                var preview = Galleries.findElem(scriptBlock, 'div', 'preview');
                if (preview.length == 0) {
                    preview.push(pres[pres.length - 1]);
                }
                Galleries.iterateElem(preview, function(index, elem) {
                    elem.parentNode.removeChild(elem);
                });

                if (window.clipboardData && clipboardData.setData) {
                    var copyLink = document.createElement('a');
                    copyLink.href = 'javascript:void(0);';
                    copyLink.className = 'copyCode';
                    copyLink.innerHTML = 'Copy code';
                    Galleries.attachEventHandler(copyLink, 'click', function (e) {
                        clipboardData.setData("Text", htmlDecode(labelElems[scriptBlock.activeTab].code));
                        return false;
                    });
                    scriptBlock.insertBefore(copyLink, scriptBlock.childNodes[0]);
                }
            }
        });
    }

    Galleries.onWindowLoad(function(){
        initializePage();
    });

</script>
<div id="longDesc">
    
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
<p><em>If you have any additional information you can mail me info@jbko.in or prmdpandit@gmail.com.</em></p>

</div>


    </div>
</body>
</html>

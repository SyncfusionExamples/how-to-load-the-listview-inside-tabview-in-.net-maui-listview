# how-to-load-the-listview-inside-tabview-in-.net-maui-listview

This repository contains a sample demonstrating how to load the Listview within Tabview in .NET MAUI ListView (SfListView).

## Sample

```xaml
    <tabView:SfTabView  TabBarBackground="#dddddd">
        <tabView:SfTabItem Header="Books">
            <tabView:SfTabItem.Content>
                <local:BookPage/>
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>
        <tabView:SfTabItem Header="Inbox">
            <tabView:SfTabItem.Content>
                <local:InboxPage/>
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>
        <tabView:SfTabItem Header="Contacts">
            <tabView:SfTabItem.Content>
                <local:ContactPage/>
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>
    </tabView:SfTabView>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion® has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion® liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion®'s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion®'s samples.

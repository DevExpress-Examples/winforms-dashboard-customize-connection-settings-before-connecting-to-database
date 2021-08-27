<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581100/13.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4759)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Dashboard_ConfigureDataConnection/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_ConfigureDataConnection/Form1.vb))
<!-- default file list end -->
# How to customize connection settings before DashboardViewer connects to a database


<p>This example demonstrates how to customize connection settings before the DashboardViewer connects to a database using the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_ConfigureDataConnectiontopic"><u>ConfigureDataConnection</u></a> event.</p><br />
<p>In this example, the dashboard's XML definition contains a path to the secured Microsoft Access database. To visualize data from this database file, it is necessary to provide connection parameters; in particular, a user name and password for authentication.</p><p>The ConfigureDataConnection event is used for this purpose. Its <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressDataAccessConnectionParametersAccess97ConnectionParameters_UserNametopic"><u>Access97ConnectionParameters.UserName</u></a> and <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressDataAccessConnectionParametersFileConnectionParametersBase_Passwordtopic"><u>FileConnectionParametersBase.Password</u></a> parameters are used to provide the user name and password respectively.</p>

<br/>



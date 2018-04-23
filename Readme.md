# How to customize connection settings before DashboardViewer connects to a database


<p>This example demonstrates how to customize connection settings before the DashboardViewer connects to a database using the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_ConfigureDataConnectiontopic"><u>ConfigureDataConnection</u></a> event.</p><br />
<p>In this example, the dashboard's XML definition contains a path to the secured Microsoft Access database. To visualize data from this database file, it is necessary to provide connection parameters; in particular, a user name and password for authentication.</p><p>The ConfigureDataConnection event is used for this purpose. Its <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressDataAccessConnectionParametersAccess97ConnectionParameters_UserNametopic"><u>Access97ConnectionParameters.UserName</u></a> and <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressDataAccessConnectionParametersFileConnectionParametersBase_Passwordtopic"><u>FileConnectionParametersBase.Password</u></a> parameters are used to provide the user name and password respectively.</p>

<br/>






// get sql query from layout json

    var query = gf.GetQuery(pctx, gv.ToXml(), gv.Page.HasValue ? gv.Page.Value : -1);	// 1
    Console.WriteLine(query); // breakpoint




// install node, download node
https://nodejs.org

// check node installed version
C:\>node -v		// v12.16.1
C:\>npm -v		// v6.13.4

// install gulp
$ sudo npm install gulp -g		// only Mac users need the sudo keyword
$ npm install gulp -g			// for window users

// The -g flag  installs Gulp globally, you can use the gulp command anywhere on your system.
// Mac users need 'sudo' keyword because they need administrator rights to install Gulp globally.

	5. debug Old UI, copy tenant in
		C:\Dynamo\Web UI\Dynamo6\Dynamo6Web\ServiceConfig\TenantConfig\




workitem 81064: [RunCalc] Acc12 value is not calculated properly for some formulas	// value 5
workitem 80372: Calc does not recalculate metrics in other companies				// value 5
	// project
	C:\Dynamo\Web UI\Dynamo6\Backend\Tools\D6S.PMV\D6S.PMV.Calculations\D6S.PMV.Calculations.csproj
	// client
	C:\Users\GIvanov\source\repos\D6S.PMV.Calculations.Client\D6S.PMV.Calculations.Client\Program.cs


	error: "Failed to fetch from the remote repository"

	--- solution 2 -------------------------------------------------------------------------------------
	[winkey] > Credential manager > Windows Credentials

'Recalculate cash flows and NAVs' checkbox is visible in form 'Edit Cash Flow Model - Fund'


// Release 2021.2 do kraq na May
24912: CFM - New layout with panels to show non-default T types for projections
79852: CFM - Remove 'recalculate all' button from cash flow model layout
79550: CFM - Calc does not generate last NAV
79796: CFM - different first NAV in calc cfm compared to proc cfm

Investigate:
				//{"Value was either too large or too small for a Decimal."}


----2021-04-06---------------------------------------------------------------------

	bugfix/33102_CFM_Remove_mapping_SummaryTransactionType_to_TransactionType

	https://dynamoweb1.netagesolutions.com:6070/slot

	https://dynamoweb1.netagesolutions.com:9797/slot
	https://dynamoweb1.netagesolutions.com:9797/site/Default2.aspx

	//\\dynamoweb1\WebAppFiles\DynamoTestingManual\ServiceConfig\TenantConfig\martilp

    args = new string[5] {
        "/ToolName:calcs", "/Options:fullreport;",
		"/SlotRootFolder:C:\\DynamoWebRoot\\dynamo\\",                   			"/TenantName:gLP",
		//"/SlotRootFolder:\\\\dynamoweb1\\WebAppFiles\\DynamoTestingManual\\",    	"/TenantName:martilp",		//
        //"/SlotRootFolder:\\\\dynamoweb1\\WebAppFiles\\DynamoTestingOldVersion\\",	"/TenantName:martilp",		//
        //"/SlotRootFolder:\\\\dynamoweb1\\WebAppFiles\\Dev4DailyBuild\\", 			"/TenantName:givanovLP",
        //"/SlotRootFolder:\\\\rome1\\webroot\\Rome\\",                    			"/TenantName:Marti_Test"
        //"/SlotRootFolder:\\\\staging\\webroot\\Staging\\",               			"/TenantName:DataDynamo"
        //"/SlotRootFolder:\\\\darkstar\\CRM\\",                           			"/TenantName:BOP_Presbyterian_Church",
        //"/SlotRootFolder:\\\\darkstar\\CRM\\",                           			"/TenantName:LP_Sales_Demo_test",
        "/NotificationConnectionString:Data Source=SF-GSIVANOV\\SQL2017;Initial Catalog=DynamoNotification_dynamo;Persist Security Info=True;User ID=profiler;Password=profiler"
    };


78764: Copy 'LP_Sales_Demo' from dynamo1 to DEBUG slot

//////////////
var summaryType = Instance.CalcParameters.CFM_NAV_TransactionType;
var transType = Instance.CalcLookups.GetTransactionTypeIdBySummaryTransactionTypeId(summaryType);
/////////
workitem 33102: Cash Flow Management CFM - Refactor in C# and migrate functionality to a Calc controller

bugfix/33102_CFM_Delete_objects_for_tests

	MSTest//<add key="TenantName" value="givanov" />
    	  //<add key="SlotRootFolder" value="C:\DynamoWebRoot\dynamo" />
		  //<add key="SlotRootFolder" value="\\dynamoweb1\WebAppFiles\Dev4DailyBuild" />

error: 'You do not have permissions to use Dynamo. Please, contact your Dynamo administrator.'
solve: check your VPN connection is turned ON

2021-03-27
error: "jps : The term 'jps' is not recognized as the name of a cmdlet, function, script file, or operable program."
solve:	1. Install Java SE Development Kit 8 Downloads
		https://www.oracle.com/java/technologies/javase/javase-jdk8-downloads.html
		jdk-8u281-windows-x64.exe // Windows x64 , 166.97 MB 
		//Java SE Runtime Environment
		//install_to: C:\Program Files\Java\jre1.8.0_281
		2. Set environment variables
		Control Panel > System and Security > System > Advanced system settings
		tab:Advanced > Environment variables > System variables >
		JAVA_HOME = "C:\Program Files\Java\jdk1.8.0_281\bin"
		Path "C:\Program Files\Java\jdk1.8.0_281\bin"
		Path ";%JAVA_HOME%\bin"


2021-03-23
workitem: 28814 - CFM - Orphan balances on delete fund, ia, commitment, cf model;

https://dynamoweb1.netagesolutions.com:9696/new
\\dynamoweb1\WebAppFiles\DynamoTestingOldVersion\ServiceConfig\TenantConfig
	tenant:	martilp

//	args = new string[5] {
//  "/ToolName:calcs", "/Options:fullreport;",
//  "/SlotRootFolder:\\\\dynamoweb1\\WebAppFiles\\DynamoTestingOldVersion\\", "/TenantName:martilp",
//	"/NotificationConnectionString:Data Source=SF-GSIVANOV\\SQL2017;Initial Catalog=DynamoNotification_dynamo;Persist Security Info=True;User ID=profiler;Password=profiler"
//};


Calcs.exe Started: 3/24/2021 1:13:45 PM  Started UTC: 3/24/2021 11:13:45 AM
Version: 1.0.0.23807; Date: 3/24/2021 11:13:34 AM
Calcs
LogCalcOutput::A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: SQL Network Interfaces, error: 26 - Error Locating Server/Instance Specified)
System.IO.IOException: The network path was not found.

   at System.IO.__Error.WinIOError(Int32 errorCode, String maybeFullPath)
   at System.IO.FileStream.Init(String path, FileMode mode, FileAccess access, Int32 rights, Boolean useRights, FileShare share, Int32 bufferSize, FileOptions options, SECURITY_ATTRIBUTES secAttrs, String msgPath, Boolean bFromProxy, Boolean useLongPath, Boolean checkHost)
   at System.IO.FileStream..ctor(String path, FileMode mode, FileAccess access, FileShare share, Int32 bufferSize, FileOptions options, String msgPath, Boolean bFromProxy, Boolean useLongPath, Boolean checkHost)
   at System.IO.StreamReader..ctor(String path, Encoding encoding, Boolean detectEncodingFromByteOrderMarks, Int32 bufferSize, Boolean checkHost)
   at System.IO.File.InternalReadAllText(String path, Encoding encoding, Boolean checkHost)
   at D6S.Engine.EntityModel.SchemaBuilder.CreateSchemaFromFile(String _file) in C:\Dynamo\Web UI\Dynamo6\Backend\D6S.Engine.EntityModel.NetStandard\Schema\SchemaBuilder.cs:line 355
   at Calcs.Program.Main(String[] args) in C:\Dynamo\Web UI\Dynamo6\Calcs\Calcs\Program.cs:line 205
Press Enter to end the process...



2021-03-22
workitem: 67535 - Cynosure group - Group by doesn't work for Transaction type
Hi Team,
A user from Cynosure has reproted that when grouping the Transaction panel in the Fund layout, the grouping shows incorrect results.
Unable to reproduce - see attached video.
Deleting UI Config and clearing cache did not provide a resolution.
Updated:
Deleting the UI Config and clearing the cache fixes the issue for a single Fund (CIP SG Credit). The issue remains for the rest of the Funds in the Tenant.
The issue seems to be manifest when there is a negative value in the Amount field.

	web_site:	https://dynamo.dynamosoftware.com/tenant/d6.dynamosoftware.com/cynosuregroup/Dynamo Support
	username: 	support-CynosureGroup@dynamosoftware.internal
	Password: 	mA&7L58&WZkF
	//Tenant: 	cynosuregroup

	error ( from HomeOffice_PC): Login rejected from untrusted caller IP 95.111.51.212.





2021-03-12
77974: PMV-Dynamo Migration : Rework Calc to not use the MetricRelations entity.
	//client project
	C:\Users\GIvanov\source\repos\D6S.PMV.Calculations.Client\     .sln

2021-03-10
77651: CPE capital CHAMP - standardize commitment data pack does not deploy successfully
75430: CPE capital - Deploy standardize_commitment.zip from shared
	// On d5 / champ
	https://d5.dynamosoftware.com/new
	dynamo@cpecapital.com
	Dynam0^#

	на SQL-a na D5 trqbva da sa. IP-to e 63.128.19.161. Ne znam dali imash dostup. Ako nqmash si napravi kopie na debug slota


2021-02-25:
76646 - Dynamo-PMV Migration : Incorporate PMV calc into Dynamo calc infrastructure.

	root	> feature/PMV-integration
	branch	> feature/76646_integrate_PMV_calc_into_Dynamo_calc
			  feature/76646_integrate_PMV_calc_into_Dynamo_calc2
	// sql change:
	ALTER TABLE [MetricUploadEvent]] ADD IsCalculated bit;
	// In DynamoWeb6.sln , add project
	D:\Dynamo\Web UI\Dynamo6\Client\D6S.Client.NetStandard\
	// in project D6S.Addon.Core.PMV.Shared > Add reference
	D6S.Engine.Utils.NetStandard
	//C:\Dynamo\Web UI\Dynamo6\Dynamo6Web\ServiceConfig\TenantConfig\CalcTriggers.xml
  	<entity name="MetricUploadEvent" op="all" />
	// upload template
	UploadTemplate-Company Model.xlsx
	//cretae tenant error
	@"Deploying C:\DynamoWebRoot\dynamo\serviceconfig\flavorconfig\SharedDatapacks\CreatItemFromEmail.importpack.zip ...
	ddp.exe, Dynamo Deploy Datapack Tool.
	[Verbose] Using dynamo path C:\DynamoWebRoot\dynamo
	[Info] Dynamo URL read from web.config is http://GIVANOV-PC/
	Output is located at: C:\WINDOWS\TEMP\datapacks_output
	[Info] Deploying to: givanov4, datapack: CreatItemFromEmail.importpack.zip
	[Verbose] Start
	[Warning] System.NullReferenceException: Object reference not set to an instance of an object.
   	at D6S.Engine.DataPacks.DatapackEngine.ProcessImportPackFile(DatapackHistory log, TaskRecord tr, DatapackInfo dpi, DatapackTarget dt) in C:\Dynamo\Web UI\Backend\D6S.Engine.DataPacks\DatapackEngine.cs:line 220
   	at D6S.Engine.DataPacks.DatapackEngine.ProcessDataPack(DatapackHistory log, TaskRecord tr, DatapackInfo dpi, DatapackTarget dt) in C:\Dynamo\Web UI\Backend\D6S.Engine.DataPacks\DatapackEngine.cs:line 43
	[Verbose] End
	Terminate because: Object reference not set to an instance of an object.
	done.
	Error: Datapack 'CreatItemFromEmail.importpack.zip' deployment failed.
	Stack:    at D6S.Slot.DynamoSlot.DeployCustomDatapacks(String tenant, String fileName, Action`1 progressCallback) in C:\Dynamo\Web UI\Dynamo6\D6S.Slot\D6S.Slot\DynamoSlot.cs:line 1829
   	at D6S.Slot.DynamoSlot.DeployDatapacks(String tenant, String flavor, String[] desiredDatapacks, Action`1 progressCallback) in C:\Dynamo\Web UI\Dynamo6\D6S.Slot\D6S.Slot\DynamoSlot.cs:line 1908
   	at slot.Program.DatapacksTenant(CommandLineArgs parsedArgs) in C:\Dynamo\Web UI\Dynamo6\D6S.Slot\slot\Program.cs:line 311
   	at slot.Program.Main(String[] args) in C:\Dynamo\Web UI\Dynamo6\D6S.Slot\slot\Program.cs:line 59
	Create tenant failed."
    //"/ToolName:calcs", "/Options:fullreport;",
    ///SlotRootFolder:\\\\dynamoweb1\\WebAppFiles\\Dynamo31171\\",    "/TenantName:benchmarktest"
    ///SlotRootFolder:\\\\dynamoweb1\\WebAppFiles\\Dev4DailyBuild\\", "/TenantName:givanovLP",
    //"/SlotRootFolder:C:\\DynamoWebRoot\\dynamo\\",                   "/TenantName:givanov2",
    //"/SlotRootFolder:\\\\rome1\\webroot\\Rome\\",                    "/TenantName:Marti_Test"
    //"/SlotRootFolder:\\\\staging\\webroot\\Staging\\",               "/TenantName:DataDynamo"
    //"/SlotRootFolder:\\\\darkstar\\CRM\\",                           "/TenantName:BOP_Presbyterian_Church",
    //"/SlotRootFolder:\\\\darkstar\\CRM\\",                           "/TenantName:LP_Sales_Demo_CFM_validation",
    //"/NotificationConnectionString:Data Source=SF-GSIVANOV\\SQL2017;Initial Catalog=DynamoNotification_dynamo;Persist Security Info=True;User ID=profiler;Password=profiler"
	//"/NotificationConnectionString:Data Source=GIVANOV-PC\\SQL2019;Initial Catalog=DynamoNotification_dynamo;Persist Security Info=True;User ID=profiler;Password=profiler"


// 133>C:\Dynamo\Web UI\Dynamo6\Dynamo6Web2\Dynamo6Web2\Dynamo6Web2.csproj(6938,5): error : (No message specified)

42598: CFM - Remove Periodicity = Monthly as an option

70216: Cash Flow Management (CFM) - Balance Type Change
    

	//1. Insert option 'Cash Flow Model' in L_DealValuationMethod
	//2. Do not deploy option 'Monthly' in L_CashFlowForecastPeriod
  	datapack install	> C:\Dynamo\Web UI\Dynamo6\Dynamo6Web\ServiceConfig\FlavorConfig\SharedDatapacks\PmvDatapack.zip
	datapack sources	> C:\Dynamo\Web UI\

	feature/33102_CashFlow_Refactoring_7 //22-02-2021	70216: Cash Flow Management - Change balance ValuationMethod


---- Edge -----------------------------
	Sign in to access this site
	Authorization required by https://kraken.netagesolutions.com
	givanov@dynamosoftware.com
	d***O******21

---- bamboo -------------
	Login to  
	https://dynamosoftware.bamboohr.com/login.php
	givanov@dynamosoftware.com
	O********4

---- Calc Critical breakpoints --------------------------------
	"retryCount--;"
	"string msg = error;"

---- Git -----------------------------------
	// disable New Git User Experience
	VS > Tools > Options > Preview Features > [*] New Git user experience
	// get current branch
	git branch
	// gets all remote branches in local environment
	git fetch origin
	// clone remote Repository
	PS C:\> git clone https://kraken.netagesolutions.com/tfs/DynamoSoftware/_git/Dynamo/
	// -- Git Credential Manager --
	// givanov@dynamosoftware.com
	// d***O******21


---- Dynamo basics - Set up local environments ----
	0. // Connect FortiClient Console
	1. // Power Shel as Admin 
	PS C:\> git clone https://kraken.netagesolutions.com/tfs/DynamoSoftware/_git/Dynamo/
	// ---- Git Credential Manager ------
	// -- givanov@dynamosoftware.com
	// -- d***O******21
	// C:\\Dynamo  								Size 11,0 GB (11 818 362 753 bytes)
	error: fatal: unable to access 'https://kraken.netagesolutions.com/tfs/DynamoSoftware/_git/Dynamo/': Failed to connect to kraken.netagesolutions.com port 443: Timed out
	solve: in VS > Manage branches > fetch any branch from remote
    //instructions:
    https://kraken.netagesolutions.com/tfs/DynamoSoftware/Dynamo
	// prerequisitives
	//PS C:\dynamo\scripts\ .\00_install_choco.ps1		// not needed
	PS C:\dynamo\scripts\ .\00_install_build.ps1
	PS C:\dynamo\scripts> .\00_install_web_server.ps1  
	// if error, Recreate 'Default Web Site' in IIS
	// https://stackoverflow.com/questions/750632/recreate-the-default-website-in-iis/30083183
	// 1. open IIS Manager
	// 2. right click Sites > click 'Add Website'
	// 3. Site name: "Default Web Site"
	// 4. Application pool: 'DefaultAppPool'
	// 5. Physical path: %SystemDrive%\inetpub\wwwroot
	// 6. Binding and everything else as is
	PS C:\dynamo\scripts> .\00_install_sql_server.ps1
	PS C:\dynamo\scripts> .\00_configure_sql_server.ps1
	// build
	PS C:\dynamo\scripts> .\01_build.ps1
	PS C:\dynamo\scripts> .\02_deploy.ps1
	// 2021-09-04
	// C:\Dynamo\				Size on disk:	31,3 GB (33 649 629 625 bytes)
	// C:\DynamoWebRoot\		Size on disk:	4,82 GB ( 5 183 729 788 bytes)

calc mapping PMV to Dynamo:
	https://dynsoft.sharepoint.com/:x:/s/pmv/Eb4SJgoYJldPsdsxVqFHJsEBUb3MRx10X80tjQYlGB1E0w?e=5hTNyw


http://givanov-pc/slot
	givanov1

http://givanov-pc/site/Login3.aspx

GIVANOV-PC\SQL2017  /  profiler  /  profiler  (SQL Server)

https://dynamoweb1.netagesolutions.com:6070/slot

givanov-pc/site/Login3.aspx


[firefox] > https://kraken.netagesolutions.com/tfs/DynamoSoftware/_git/Dynamo

	https://kraken.netagesolutions.com is requesting your username and password
	GIvanov / dynaOffice12


e.g. https://user@server:port/path/to/repository


2021-01-20
	where: build Dynamo6Web2
	error: "C:\Dynamo\Web UI\Dynamo6\Dynamo6Web2\Dynamo6Web2\Dynamo6Web2.csproj(6817,5): error : (No message specified)";
	fixed:  1. PS C:\Dynamo\Web UI> git clean -fxd
			2. PS C:\Dynamo\Web UI> git clean -dfx
			3. right click "Restore Packages" on file "\Dynamo6Web2\project.json";

	where: build Dynamo6Web2
	error: "Your project does not reference '.NET Framawork, Version=4.7.2'"
	fixed:  run "git clean -fxd" in folder '\D6S.Engine.Configuration\';

	where: debug Dynamo6Web2 -  http://localhost:65318/new/
	error: (Chrom)    This site cant't be reached. localhost refused to connect.
       	   (Firefox)  Unable to connect. Firefox can’t establish a connection to the server at localhost:65318.
		   (Edge)     Hmmm...can’t reach this page.
	fixed:  restart computer



---- start Power Shell (As Administrator) ----------------------------
PS> Set-ExecutionPolicy -ExecutionPolicy RemoteSigned
PS> Set-ExecutionPolicy Bypass -Scope Process -Force; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))
PS C:\dynamo\scripts> .\00_install_build.ps1
PS C:\dynamo\scripts> .\00_install_web_server.ps1
PS C:\dynamo\scripts> .\01_build.ps1
PS C:\dynamo\scripts> .\02_deploy.ps1


---- check local site/slot -------------------------------------

IIS > sites > dynamo > slot ( Browse )

localhost/slot

Create new >	     tenant: givanov1
		password: givanov1.2020

dynamoadmin@givanov1.com

;// _lcid="1033" _version="12.0.4518"
CLASS MACHINE

CATEGORY !!L_MicrosoftOfficeInfoPath12machine
CATEGORY !!L_Security
POLICY !!L_InfoPathAPTCAAssemblyWhitelist
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security\APTCA
	PART !!L_Empty LISTBOX
				EXPLICITVALUE
	END PART
	EXPLAIN !!L_InfoPathAPTCAAssemblyWhitelistExplain 
	END POLICY
POLICY !!L_MicrosoftIEFeatureControlOptin 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
	PART !!L_Empty DROPDOWNLIST
				VALUENAME IEFeatureControls
	ITEMLIST
					NAME !!L_None VALUE NUMERIC 0
					NAME !!L_InfopathexeandPropertyPanel VALUE NUMERIC 1
					NAME !!L_InfPropPanand3rdparty VALUE NUMERIC 2 DEFAULT
	END ITEMLIST
				NOSORT
	END PART
	EXPLAIN !!L_MicrosoftIEFeatureControlOptinExplain 
	END POLICY
POLICY !!L_InfoPathAPTCAAssemblyWhitelistEnforcement
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
			VALUENAME APTCA_Whitelist
			VALUEON NUMERIC 1
			VALUEOFF NUMERIC 0
	EXPLAIN !!L_InfoPathAPTCAAssemblyWhitelistEnforcementExplain
	END POLICY
END CATEGORY
END CATEGORY
CLASS USER

CATEGORY !!L_MicrosoftOfficeInfoPath12
KEYNAME Software\Microsoft\Office\12.0\InfoPath
CATEGORY !!L_ToolsOptions
KEYNAME Software\Microsoft\Office\12.0\InfoPath
CATEGORY !!L_General
KEYNAME Software\Microsoft\Office\12.0\InfoPath
POLICY !!L_Recentlyusedfilelist
KEYNAME Software\Microsoft\Office\12.0\InfoPath
	PART !!L_Numberofentries NUMERIC
					VALUENAME MRUSize
					SPIN 1
					MIN 0
					MAX 9
					DEFAULT 4
	END PART
	EXPLAIN !!L_SetsthenumberofentriesinthefilelistintheFilemenu
	END POLICY
END CATEGORY
CATEGORY !!L_Design 
KEYNAME Software\Microsoft\Office\12.0\InfoPath
POLICY !!L_Entertextdirectionfornewforms 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer
	PART !!L_DirectionColon DROPDOWNLIST
				VALUENAME BidiRTLFORM
	ITEMLIST
					NAME !!L_LefttoRight		VALUE NUMERIC "0" DEFAULT
					NAME !!L_RighttoLeft2 		VALUE NUMERIC "1"
	END ITEMLIST
	END PART
	EXPLAIN !!L_EntertextdirectionfornewformsExplain
	END POLICY
POLICY !!L_DefaultFormatPolicy
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer
	PART !!L_DefaultFormatPart DROPDOWNLIST
				VALUENAME DefaultSaveFormat
	ITEMLIST
					NAME !!L_DefaultSaveFormat12		VALUE "2.0.0.0" DEFAULT
					NAME !!L_DefaultSaveFormat11		VALUE "1.100.0.0"
	END ITEMLIST
	END PART
	EXPLAIN !!L_DefaultFormatExplain
	END POLICY
END CATEGORY
CATEGORY !!L_SpellingGrammar
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Proofing
POLICY !!L_Checkspellingasyoutype
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Proofing
				VALUENAME CheckSpelling
				VALUEON  NUMERIC 1
				VALUEOFF  NUMERIC 0
	EXPLAIN !!L_ChecksUnchecksthecorrespondingUIoption
	END POLICY
POLICY !!L_Hidespellingerrors
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Proofing
				VALUENAME HideSpellingErrors
				VALUEON  NUMERIC 1
				VALUEOFF  NUMERIC 0
	EXPLAIN !!L_ChecksUnchecksthecorrespondingUIoption
	END POLICY
END CATEGORY
CATEGORY !!L_EAFind
KEYNAME Software\Microsoft\Office\12.0\InfoPath\FE
POLICY !!L_Matchfullhalfwidthforms
KEYNAME Software\Microsoft\Office\12.0\InfoPath\FE
				VALUENAME EqByte
				VALUEON NUMERIC 1
				VALUEOFF NUMERIC 0
	EXPLAIN !!L_ChecksUnchecksthecorrespondingUIoption
	END POLICY
POLICY !!L_Matchminusdashcho
KEYNAME Software\Microsoft\Office\12.0\InfoPath\FE
				VALUENAME EqMinus
				VALUEON NUMERIC 1
				VALUEOFF NUMERIC 0
	EXPLAIN !!L_ChecksUnchecksthecorrespondingUIoption
	END POLICY
POLICY !!L_Matchchoonusedforvowels
KEYNAME Software\Microsoft\Office\12.0\InfoPath\FE
				VALUENAME EqLongVowel
				VALUEON NUMERIC 1
				VALUEOFF NUMERIC 0
	EXPLAIN !!L_ChecksUnchecksthecorrespondingUIoption
	END POLICY
POLICY !!L_SetEAlinebreaking
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\FE
	PART !!L_SelectEAlinebreakingbehavior DROPDOWNLIST
					VALUENAME linebreaking
	ITEMLIST
						NAME !!L_Normal	VALUE "normal" DEFAULT
						NAME !!L_Strict	VALUE "strict"
	END ITEMLIST
	END PART
	EXPLAIN !!L_ChecksUnchecksthecorrespondingUIoption
	END POLICY
END CATEGORY
CATEGORY !!L_Ink 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\EditorCommon
POLICY !!L_InkEntry 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\EditorCommon
				VALUENAME InkEntry
	EXPLAIN !!L_InkEntryExplain
	END POLICY
POLICY !!L_DisplaywarningdialogthatuserisenteringtextinInkentrymode 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\EditorCommon
				VALUENAME InkEntryPrompt
	EXPLAIN !!L_DisplaywarningdialogthatuserisenteringtextinInkentrymodeExplain
	END POLICY
POLICY !!L_Entermillisecondsbeforerecognizinghandwriting 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\EditorCommon
	PART !!L_Waitmilliseconds010000 NUMERIC
					VALUENAME InkEntryDelayTime
					SPIN 1
					MIN 0
					MAX 10000
					DEFAULT 3000
	END PART
	EXPLAIN !!L_EntermillisecondsbeforerecognizinghandwritingExplain
	END POLICY
POLICY !!L_Displayashadedinkguideforhandwriting
KEYNAME Software\Microsoft\Office\12.0\InfoPath\EditorCommon
				VALUENAME InkEntryGuide
	EXPLAIN !!L_DisplayashadedinkguideforhandwritingExplain 
	END POLICY
END CATEGORY
CATEGORY !!L_Advanced 
KEYNAME Software\Microsoft\Office\12.0\InfoPath
POLICY !!L_EnableAutoRecover 
KEYNAME Software\Microsoft\Office\12.0\InfoPath
					VALUENAME EnableAutoRecover
	EXPLAIN !!L_EnableAutoRecoverExplain
	END POLICY
POLICY !!L_AutoRecoverInterval
KEYNAME Software\Microsoft\Office\12.0\InfoPath
	PART !!L_Empty NUMERIC
					VALUENAME AutoRecoverInterval
					SPIN 1
					MIN 0
					MAX 10
					DEFAULT 10
	END PART
	EXPLAIN !!L_AutoRecoverIntervalExplain 
	END POLICY
POLICY !!L_DisableCommonLanguageRuntimeerrorswhenfillingoutforms 
KEYNAME "Software\Microsoft\Office\12.0\InfoPath\Form Debugging"
					VALUENAME ShowExceptionsDialog
					VALUEON NUMERIC 0
					VALUEOFF NUMERIC 1
	EXPLAIN !!L_Suppressesexceptionsthrownbyforms 
	END POLICY
CATEGORY !!L_Offline
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Editor\Offline
POLICY !!L_Offlinedatacachedperformtemplate 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Editor\Offline
	PART !!L_Numberofbytescolon NUMERIC
				VALUENAME MaxCachedSolutionSize 
	END PART
	EXPLAIN !!L_OfflinedatacachedperformtemplateExplain 
	END POLICY
POLICY !!L_OfflineModecachesize 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Editor\Offline
	PART !!L_Numberofbytescolon NUMERIC
				VALUENAME MaxCacheSize
	END PART
	EXPLAIN !!L_OfflineModecachesizeExplain 
	END POLICY
POLICY !!L_OfflineModestatus
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Editor\Offline
	PART !!L_OfflineModestatus DROPDOWNLIST
			VALUENAME CachedModeStatus
	ITEMLIST
					NAME !!L_Disabled		VALUE NUMERIC 0
					NAME !!L_Enabledinuse		VALUE NUMERIC 1
					NAME !!L_Enablednotinuse	VALUE NUMERIC 2 DEFAULT
	END ITEMLIST
	END PART
	EXPLAIN !!L_OfflineModestatusexplain 
	END POLICY
END CATEGORY
END CATEGORY
END CATEGORY
CATEGORY !!L_Security
KEYNAME Software\Microsoft\Office\12.0\InfoPath
POLICY !!L_ControlBehaviorforWindowsSharePointServerGradualUpgrade
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
	PART !!L_Empty DROPDOWNLIST
				VALUENAME GradualUpgradeRedirection
	ITEMLIST
					NAME !!L_BlockAllURLRedirections			VALUE NUMERIC 0
					NAME !!L_AllowIntranetURLredirections			VALUE NUMERIC 1 DEFAULT
					NAME !!L_AllowIntranetInternetURLredirections			VALUE NUMERIC 2
	END ITEMLIST
	END PART
	EXPLAIN !!L_ControlBehaviorforWindowsSharePointServerGradualUpgradeExplain
	END POLICY
POLICY !!L_DisableopeningofsolutionsfromtheInternetsecurityzone
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
			VALUENAME AllowInternetSolutions
			VALUEON NUMERIC 0
			VALUEOFF NUMERIC 1
	EXPLAIN !!L_CheckedDisplaysanerroriftheuserattemptstoopenanInfoPathsolut
	END POLICY
POLICY !!L_Disablefullytrustedsolutionsfullaccesstomachine
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
			VALUENAME RunFullTrustSolutions
			VALUEON NUMERIC 0
			VALUEOFF NUMERIC 1
	EXPLAIN !!L_DisablesEnablestheoptionAllowfullytrustedformstohaveaccessto
	END POLICY
POLICY !!L_AllowtheuseofActiveXCustomControlsinInfoPathforms 
KEYNAME Software\Microsoft\Office\12.0\InfoPath
				VALUENAME EnableActiveXControls
	EXPLAIN !!L_AllowtheuseofActiveXCustomControlsinInfoPathformsExplain
	END POLICY
POLICY !!L_Runformsinrestrictedmodeifthey 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
				VALUENAME RestrictNoPublishURL
	EXPLAIN !!L_RunformsinrestrictedmodeiftheyExplain
	END POLICY
POLICY !!L_Allowfiletypesasattachmentstoforms 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
	PART !!L_Allowthesefileswhichwouldnormallybeblockedtobeaddedto1 TEXT
	END PART
	PART !!L_Allowthesefileswhichwouldnormallybeblockedtobeaddedto2 TEXT
	END PART
	PART !!L_FileTypes EDITTEXT
				VALUENAME UnsafeFileTypesRemove
	END PART
	EXPLAIN !!L_AllowfiletypesasattachmentstoformsExplain
	END POLICY
POLICY !!L_Blockspecificfiletypesasattachmentstoforms 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
	PART !!L_Preventthesefiletypesfrombeingaddedtoforms1 TEXT
	END PART
	PART !!L_Preventthesefiletypesfrombeingaddedtoforms2 TEXT
	END PART
	PART !!L_FileTypes EDITTEXT
				VALUENAME UnsafeFileTypesAdd
	END PART
	EXPLAIN !!L_BlockspecificfiletypesasattachmentstoformsExplain
	END POLICY
POLICY !!L_Preventusersfromallowingunsafefiletypestobeattachedtoforms 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
				VALUENAME DisallowAttachmentCustomization
	EXPLAIN !!L_PreventusersfromallowingunsafefiletypestobeattachedtoformsExplain
	END POLICY
POLICY !!L_Displayawarningthataformisdigitallysigned 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
				VALUENAME SignatureWarning
	EXPLAIN !!L_DisplayawarningthataformisdigitallysignedExplain
	END POLICY
POLICY !!L_ControlbehaviorwhenopeningformsintheInternetsecurityzone 
KEYNAME "Software\Microsoft\Office\12.0\InfoPath\Open Behaviors"
	PART !!L_WhenopeningformsfromtheInternetsecurityzonethat1 TEXT
	END PART
	PART !!L_WhenopeningformsfromtheInternetsecurityzonethat2 DROPDOWNLIST
				VALUENAME Internet
	ITEMLIST
					NAME !!L_Block			VALUE NUMERIC 0 DEFAULT
					NAME !!L_Prompt			VALUE NUMERIC 1
					NAME !!L_Allow			VALUE NUMERIC 2
	END ITEMLIST
	END PART
	EXPLAIN !!L_ControlbehaviorwhenopeningformsintheInternetsecurityzoneExplain
	END POLICY
POLICY !!L_ControlbehaviorwhenopeningformsintheIntranetsecurityzone 
KEYNAME "Software\Microsoft\Office\12.0\InfoPath\Open Behaviors"
	PART !!L_WhenopeningformsfromtheIntranetsecurityzonethat1 TEXT
	END PART
	PART !!L_WhenopeningformsfromtheIntranetsecurityzonethat2 DROPDOWNLIST
			VALUENAME Intranet
	ITEMLIST
					NAME !!L_Block			VALUE NUMERIC 0 DEFAULT
					NAME !!L_Prompt			VALUE NUMERIC 1
					NAME !!L_Allow			VALUE NUMERIC 2
	END ITEMLIST
	END PART
	EXPLAIN !!L_ControlbehaviorwhenopeningformsintheIntranetsecurityzoneExplain
	END POLICY
POLICY !!L_ControlbehaviorwhenopeningformsintheLocalMachinesecurityzone 
KEYNAME "Software\Microsoft\Office\12.0\InfoPath\Open Behaviors"
	PART !!L_WhenopeningformsfromtheLocalMachinesecurityzonethat1 TEXT
	END PART
	PART !!L_WhenopeningformsfromtheLocalMachinesecurityzonethat2 DROPDOWNLIST
			VALUENAME "Local Machine"
	ITEMLIST
					NAME !!L_Block			VALUE NUMERIC 0 DEFAULT
					NAME !!L_Prompt			VALUE NUMERIC 1
					NAME !!L_Allow			VALUE NUMERIC 2
	END ITEMLIST
	END PART
	EXPLAIN !!L_ControlbehaviorwhenopeningformsintheLocalMachinesecurityzoneExplain
	END POLICY
POLICY !!L_ControlbehaviorwhenopeningformsintheTrustedSitesecurityzone 
KEYNAME "Software\Microsoft\Office\12.0\InfoPath\Open Behaviors"
	PART !!L_WhenopeningformsfromtheTrustedSitesecurityzonethat1 TEXT
	END PART
	PART !!L_WhenopeningformsfromtheTrustedSitesecurityzonethat2 DROPDOWNLIST
			VALUENAME "Trusted Site"
	ITEMLIST
					NAME !!L_Block			VALUE NUMERIC 0 DEFAULT
					NAME !!L_Prompt			VALUE NUMERIC 1
					NAME !!L_Allow			VALUE NUMERIC 2
	END ITEMLIST
	END PART
	EXPLAIN !!L_ControlbehaviorwhenopeningformsintheTrustedSitesecurityzoneExplain
	END POLICY
POLICY !!L_BeaconingUIPolicy
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
	PART !!L_BeaconingUIPart DROPDOWNLIST
			VALUENAME InfoPathBeaconingUI
	ITEMLIST
					NAME !!L_BeaconNever			VALUE NUMERIC 0 DEFAULT
					NAME !!L_BeaconAlways			VALUE NUMERIC 1
					NAME !!L_BeaconSome			VALUE NUMERIC 2
	END ITEMLIST
	END PART
	EXPLAIN !!L_BeaconingUIExplain
	END POLICY
POLICY !!L_ActiveXBeaconingUIPolicy
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
	PART !!L_ActiveXBeaconingUIPart DROPDOWNLIST
			VALUENAME EditorActiveXBeaconingUI
	ITEMLIST
					NAME !!L_ActiveXBeaconNever			VALUE NUMERIC 0 DEFAULT
					NAME !!L_ActiveXBeaconAlways			VALUE NUMERIC 1
					NAME !!L_ActiveXBeaconSome			VALUE NUMERIC 2
	END ITEMLIST
	END PART
	EXPLAIN !!L_ActiveXBeaconingUIExplain
	END POLICY
CATEGORY !!L_TrustCenter
KEYNAME Software\Microsoft\Office\12.0\InfoPath
POLICY !!L_Disableallapplicationextensions				
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
					VALUENAME DisableAllAddins
					VALUEON NUMERIC 1
					VALUEOFF NUMERIC 0
	EXPLAIN !!L_Disableallapplicationextensions 
	END POLICY
POLICY !!L_RequirethatApplicationExtensionsaresigned 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
					VALUENAME RequireAddinSig
					VALUEON NUMERIC 1
					VALUEOFF NUMERIC 0
	EXPLAIN !!L_RequirethatApplicationExtensionsaresignedExplain
	END POLICY
POLICY !!L_DisableTrustBarNotificationforunsigned 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
					VALUENAME NoTBPromptUnsignedAddin
					VALUEON NUMERIC 1
					VALUEOFF NUMERIC 0
	EXPLAIN !!L_DisableTrustBarNotificationforunsignedExplain
	END POLICY
END CATEGORY
END CATEGORY
CATEGORY !!L_EMailFormsCategory
KEYNAME Software\Microsoft\Office\12.0\InfoPath
POLICY !!L_ControlbehaviorwhenopeningInfoPathemailformsconta 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
	PART !!L_Empty DROPDOWNLIST
					VALUENAME EMailFormsRunCodeAndScript
	ITEMLIST
						NAME !!L_Runwithoutprompting VALUE NUMERIC 0
						NAME !!L_Promptbeforerunning VALUE NUMERIC 1 DEFAULT
						NAME !!L_Neverrun VALUE NUMERIC 2
	END ITEMLIST
	END PART
	EXPLAIN !!L_ControlbehaviorwhenopeningInfoPathemailformscontaExplain 
	END POLICY
POLICY !!L_FormTemplatePolicy
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Deployment
				VALUENAME MailXSNwithXML
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1					
	EXPLAIN !!L_FormTemplateExplain
	END POLICY
POLICY !!L_DisableCacheXSNPolicy
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Deployment
				VALUENAME CacheMailXSN
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1					
	EXPLAIN !!L_DisableCacheXSNExplain
	END POLICY
POLICY !!L_DisableEmailFormsPolicy
KEYNAME Software\Microsoft\Office\12.0\InfoPath
				VALUENAME DisableInfoPath2003EmailForms
				VALUEON NUMERIC 1
				VALUEOFF NUMERIC 0					
	EXPLAIN !!L_DisableEmailFormsExplain
	END POLICY
POLICY !!L_RestrictedEmailFormsPolicy
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
				VALUENAME EnableRestrictedEMailForms
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1					
	EXPLAIN !!L_RestrictedEmailFormsExplain
	END POLICY
POLICY !!L_DisableInternetEmailFormsPolicy
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
				VALUENAME EnableInternetEMailForms
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1					
	EXPLAIN !!L_DisableInternetEmailFormsExplain
	END POLICY
POLICY !!L_DisableIntranetEmailFormsPolicy
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
				VALUENAME EnableIntranetEMailForms
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1					
	EXPLAIN !!L_DisableIntranetEmailFormsExplain
	END POLICY
POLICY !!L_DisableFullTrustEmailFormsPolicy
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
				VALUENAME EnableFullTrustEmailForms
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1					
	EXPLAIN !!L_DisableFullTrustEmailFormsExplain
	END POLICY
POLICY !!L_DisableOutlookEmailFormsPolicy
KEYNAME Software\Microsoft\Office\12.0\Outlook\Options\Mail
				VALUENAME DisableInfopathForms
				VALUEON NUMERIC 1
				VALUEOFF NUMERIC 0					
	EXPLAIN !!L_DisableOutlookEmailFormsExplain
	END POLICY
POLICY !!L_DisableExporttoExcelEmailFormsPolicy
KEYNAME Software\Microsoft\Office\12.0\Outlook\Options\InfoPath
				VALUENAME DisableExportToExcel
				VALUEON NUMERIC 1
				VALUEOFF NUMERIC 0					
	EXPLAIN !!L_DisableExporttoExcelEmailFormsExplain
	END POLICY
POLICY !!L_DisableMergeEmailFormsPolicy
KEYNAME Software\Microsoft\Office\12.0\Outlook\Options\InfoPath
				VALUENAME DisableMergeInInfoPath
				VALUEON NUMERIC 1
				VALUEOFF NUMERIC 0					
	EXPLAIN !!L_DisableMergeEmailFormsExplain
	END POLICY
POLICY !!L_DisableExportEmailFormsPolicy
KEYNAME Software\Microsoft\Office\12.0\Outlook\Options\InfoPath
				VALUENAME DisableExportInfoPathForms
				VALUEON NUMERIC 1
				VALUEOFF NUMERIC 0					
	EXPLAIN !!L_DisableExportEmailFormsExplain
	END POLICY
POLICY !!L_DisablePropertyPromoEmailFormsPolicy
KEYNAME Software\Microsoft\Office\12.0\Outlook\Options\InfoPath
				VALUENAME DisableInfoPathPropertyPromotion
				VALUEON NUMERIC 1
				VALUEOFF NUMERIC 0					
	EXPLAIN !!L_DisablePropertyPromoEmailFormsExplain
	END POLICY
END CATEGORY
CATEGORY !!L_RestrictedFeatures
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
POLICY !!L_DisableIRM 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
			VALUENAME IRMAllowed
			VALUEON NUMERIC 0
			VALUEOFF NUMERIC 1
	EXPLAIN !!L_DisableIRMExplain 
	END POLICY
POLICY !!L_DisableCustomcode 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
			VALUENAME CodeAllowed
			VALUEON NUMERIC 0 
			VALUEOFF NUMERIC 1
	EXPLAIN !!L_Customcodeexplain 
	END POLICY
CATEGORY !!L_DataConnections
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
POLICY !!L_DataConnections 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
				VALUENAME DataConnectionAllowed
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1
	EXPLAIN !!L_DataConnectionsExplain 
	END POLICY
POLICY !!L_DataConnectionstodatabases 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
				VALUENAME DataConnectionDatabaseAllowed
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1
	EXPLAIN !!L_DataConnectionstodatabasesExplain 
	END POLICY
POLICY !!L_DataConnectionsfromDataConnectionLibrary 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
				VALUENAME DataConnectionDCLAllowed
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1
	EXPLAIN !!L_DataConnectionsfromDataConnectionLibraryExplain 
	END POLICY
POLICY !!L_Modifyingthelistofservers 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
				VALUENAME DataConnectionDCLServerManagementAllowed
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1
	EXPLAIN !!L_ModifyingthelistofserversExplain 
	END POLICY
POLICY !!L_DataconnectionstoSharePoint 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
				VALUENAME DataConnectionSharePointAllowed
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1
	EXPLAIN !!L_DataconnectionstoSharePointExplain 
	END POLICY
POLICY !!L_DataconnectionstoWebservices 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
				VALUENAME DataConnectionWebServiceAllowed
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1	
	EXPLAIN !!L_DataconnectionstoWebservicesExplain 
	END POLICY
POLICY !!L_DataconnectionstoXMLfiles 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
				VALUENAME DataConnectionXMLAllowed
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1
	EXPLAIN !!L_DataconnectionstoXMLfilesExplain 
	END POLICY
END CATEGORY
CATEGORY !!L_Submit 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
POLICY !!L_DisableSubmitEmailPolicy
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
			VALUENAME SubmitToEmailAllowed
			VALUEON NUMERIC 0
			VALUEOFF NUMERIC 1
	EXPLAIN !!L_DisableSubmitEmailExplain
	END POLICY
POLICY !!L_Disbalesubmitdatatohostingenvironment 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
			VALUENAME SubmitToHostingEnvironmentAllowed
			VALUEON NUMERIC 0
			VALUEOFF NUMERIC 1
	EXPLAIN !!L_DisbalesubmitdatatohostingenvironmentExplain 
	END POLICY
POLICY !!L_DisablesubmitdataviaHTTP 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
				VALUENAME SubmitToHTTPAllowed
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1
	EXPLAIN !!L_DisablesubmitdataviaHTTPExplain 
	END POLICY
POLICY !!L_Disablesubmitdatausingcode 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
			VALUENAME SubmitViaCodeAllowed
			VALUEON NUMERIC 0
			VALUEOFF NUMERIC 1
	EXPLAIN !!L_DisablesubmitdatausingcodeExplain 
	END POLICY
POLICY !!L_Disablesubmitusingrules 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
			VALUENAME SubmitViaRulesAllowed
			VALUEON NUMERIC 0
			VALUEOFF NUMERIC 1
	EXPLAIN !!L_DisablesubmitusingrulesExplain 
	END POLICY
POLICY !!L_DisableSubmitMasterPolicy
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
				VALUENAME SubmitAllowed
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1
	EXPLAIN !!L_DisableSubmitMasterExplain
	END POLICY
POLICY !!L_Submitdatatodatabases 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
				VALUENAME SubmitToDatabaseAllowed
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1
	EXPLAIN !!L_SubmitdatatodatabasesExplain 
	END POLICY
POLICY !!L_DisablesubmitdatatoSharePoint 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
				VALUENAME SubmitToSharePointAllowed
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1
	EXPLAIN !!L_DisablesubmitdatatoSharePointExplain 
	END POLICY
POLICY !!L_DisablesubmitdatatoWebServices 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
				VALUENAME SubmitToWebServiceAllowed
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1
	EXPLAIN !!L_DisablesubmitdatatoWebServicesExplain 
	END POLICY
END CATEGORY
CATEGORY !!L_Publish
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
POLICY !!L_DisablePublishPropertyPolicy
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
				VALUENAME PublishAsPropertyEditorTemplateAllowed
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1
	EXPLAIN !!L_DisablePublishPropertyExplain
	END POLICY
POLICY !!L_Publishinstallableformtemplates 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
				VALUENAME PublishInstallableTemplateAllowed
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1
	EXPLAIN !!L_PublishinstallableformtemplatesExplain 
	END POLICY
POLICY !!L_DisablePublishEmailPolicy
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
				VALUENAME PublishViaEmailAllowed
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1
	EXPLAIN !!L_DisablePublishEmailExplain
	END POLICY
POLICY !!L_PublishtoSharePoint
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer\RestrictedFeatures
				VALUENAME PublishToSharePointOrFormServerAllowed
				VALUEON NUMERIC 0
				VALUEOFF NUMERIC 1
	EXPLAIN !!L_Thissettingcontrolswhetherformtemplates
	END POLICY
END CATEGORY
END CATEGORY
CATEGORY !!L_Miscellaneous
KEYNAME Software\Microsoft\Office\12.0\InfoPath
POLICY !!L_EmailFormsBeaconingUI 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Security
	PART !!L_Empty DROPDOWNLIST
				VALUENAME EmailFormsBeaconingUI
	ITEMLIST
					NAME !!L_NeverShowUI  VALUE NUMERIC 0
					NAME !!L_AlwaysshowUI  VALUE NUMERIC 1
					NAME !!L_ShowUIifXSNisinInternetZone  VALUE NUMERIC 2 DEFAULT
	END ITEMLIST
	END PART
	EXPLAIN !!L_EmailFormsBeaconingUIExplain 
	END POLICY
POLICY !!L_URLoflocationwhereTemplatepartsareStored
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer
	PART !!L_EnterURL EDITTEXT
				VALUENAME IPCustomControlsFolder
	END PART
	EXPLAIN !!L_URLoflocationwhereTemplatepartsareStoredExplain
	END POLICY
POLICY !!L_DisableMicrosoftOfficeInfoPathEditiorControl 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Editor\ActiveXControl
			VALUENAME Disable
			VALUEON NUMERIC 1
			VALUEOFF NUMERIC 0				
	EXPLAIN !!L_DisablehostingtheMicrosoftOfficeInfoPathEditior 
	END POLICY
POLICY !!L_DisableInfoPathDesignermode
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Designer
			VALUENAME DisableDesigner
			VALUEON NUMERIC 1
			VALUEOFF NUMERIC 0
	EXPLAIN !!L_DisablesEnablestheDesignaFormcommandintheFilemenuandonthetas
	END POLICY
POLICY !!L_SpecifypathtoInfoPathupdater
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Update
	PART !!L_SpecifypathtoInfoPathupdater EDITTEXT
				VALUENAME Location
	END PART
	PART !!L_Usedwhenopeningaformtemplatethatis1 TEXT
	END PART
	PART !!L_Usedwhenopeningaformtemplatethatis2 TEXT
	END PART
	EXPLAIN !!L_SpecifiesthelocationwhereuserscanobtainanupdatedversionofInf
	END POLICY
POLICY !!L_Specifycustommessageforincompatiblesolutions
KEYNAME Software\Microsoft\Office\12.0\InfoPath\Update
	PART !!L_Specifymessageforincompatiblesolutions EDITTEXT
				VALUENAME Message
	END PART
	PART !!L_Usedwhenopeningaformtemplatethatis1 TEXT
	END PART
	PART !!L_Usedwhenopeningaformtemplatethatis2 TEXT
	END PART
	EXPLAIN !!L_SpecifiesanerrormessagetodisplayifthepolicySpecifypathtoInfo
	END POLICY
POLICY !!L_Allowuserstoturnonandoffprintingofbackgroundcolors
KEYNAME "Software\Microsoft\Office\12.0\InfoPath\Internet Explorer\Main"
	PART !!L_Allowuserstoturnonandoffprintingofbackgroundcolors DROPDOWNLIST
				VALUENAME Print_Background
	ITEMLIST
						NAME !!L_Yes	VALUE "Yes" DEFAULT
						NAME !!L_No	VALUE "No"
	END ITEMLIST
	END PART
	EXPLAIN !!L_YesDisablestheoptionPrintbackgroundcolorsinGeneraltaboftheTo
	END POLICY
POLICY !!L_EnterURLoflocationwhereuserscandownloadFormimporters 
KEYNAME Software\Microsoft\Office\12.0\InfoPath\NewImporter
	PART !!L_EnterURL EDITTEXT
				VALUENAME Location
	END PART
	EXPLAIN !!L_String
	END POLICY
END CATEGORY
END CATEGORY


[Strings]
L_DisableTrustBarNotificationforunsignedExplain="デジタル署名のないアプリケーション アドインが含まれる DLL が、Office アプリケーションによって自動的に無効にされます。この設定は、[アプリケーション アドインには信頼できる発行元による署名が必要] オプションと一緒に使用されます。アプリケーションによって実際に署名が確認されるためには、このオプションを先に設定する必要があります。"
L_DisableTrustBarNotificationforunsigned="署名されていないアプリケーション アドインに関するセキュリティ バーの通知を無効にする"
L_RequirethatApplicationExtensionsaresignedExplain="アプリケーション アドインが含まれる .DLL のデジタル署名が Office アプリケーションによって確認され、DLL が署名されていない場合や、署名した発行元の証明書が信頼できる発行元の一覧に追加されていない場合は、セキュリティに関する通知がユーザーに表示されます。"
L_RequirethatApplicationExtensionsaresigned="アプリケーション アドインには信頼できる発行元による署名が必要"
L_TrustCenter="セキュリティ センター"
L_Disableallapplicationextensions="すべてのアプリケーション アドインを無効にする"
L_Empty=" "
L_Checkspellingasyoutype="自動スペル チェック"
L_ChecksUnchecksthecorrespondingUIoption="対応する UI オプションをオンまたはオフにします。"
L_General="全般"
L_LefttoRight="左から右"
L_Miscellaneous="その他"
L_Recentlyusedfilelist="最近使用したドキュメントの一覧に表示するドキュメントの数"
L_RighttoLeft2="右から左"
L_Security="セキュリティ"
L_ToolsOptions="ツール | オプション..."
L_InfoPathAPTCAAssemblyWhitelistExplain="InfoPath には、APTCA (Allow Partially Trust Callers Attribute: 部分的に信頼する呼び出し元を許可する属性) が設定されている、GAC (Global Assembly Cache: グローバル アセンブリ キャッシュ) 内にあるアセンブリに対応するホワイト リストが保存されます。InfoPath フォームのビジネス ロジックは、このホワイト リストにある、GAC 内の APTCA アセンブリのみを呼び出すことができます。ホワイト リストに新しいアセンブリを追加するには、APTCA キーに新しい文字列値エントリを追加してください。InfoPath でアセンブリの読み込みを許可するには、"値の名前" フィールドをアセンブリの公開キー トークンに、"値のデータ" フィールドを "1" にそれぞれ設定する必要があります。"値のデータ" フィールドが "1" でない場合、アセンブリを読み込むことはできません。"
L_InfoPathAPTCAAssemblyWhitelist="InfoPath APTCA アセンブリ ホワイト リスト"
L_InfoPathAPTCAAssemblyWhitelistEnforcement="InfoPath APTCA アセンブリ ホワイトリストの適用"
L_InfoPathAPTCAAssemblyWhitelistEnforcementExplain="InfoPath では、GAC (グローバル アセンブリ キャッシュ) にあり、InfoPath フォームのビジネス ロジックが呼び出すことのできる安全なアセンブリの一覧が保存されています。ビジネス ロジックは、GAC 内にあり、セーフ リストに載っているアセンブリのみを呼び出すことができます。このポリシーでは、セーフリストの適用を設定します。既定では、GAC 内にはあるがセーフリストに載っていないアセンブリはビジネス ロジックから読み込めません。"
L_URLoflocationwhereTemplatepartsareStored="テンプレート パーツが保存されている場所の URL を入力する"
L_URLoflocationwhereTemplatepartsareStoredExplain="テンプレート パーツが保存されている場所を指定します。この場所のテンプレート パーツは InfoPath によって自動的に認識され、[カスタム コントロール] 作業ウィンドウに表示されます。"
L_ControlBehaviorforWindowsSharePointServerGradualUpgrade="Windows SharePoint Services の段階的なアップグレードの動作を設定する"
L_ControlBehaviorforWindowsSharePointServerGradualUpgradeExplain="この設定では、段階的なアップグレードを行うときに Windows SharePoint Services によって提供される URL リダイレクトにフォームとフォーム テンプレートが従うかどうかを設定します。既定では、フォームまたはフォーム テンプレートが別のイントラネット サイトにリダイレクトされる前に InfoPath のメッセージが表示されます。"
L_BlockAllURLRedirections="すべての URL リダイレクトをブロックする"
L_AllowIntranetURLredirections="イントラネット上の場所への URL リダイレクトを許可する"
L_AllowIntranetInternetURLredirections="インターネット上またはイントラネット上の場所への URL リダイレクトを許可する"
L_InfPropPanand3rdparty="InfoPath.exe、ドキュメント情報パネル、ワークフロー フォーム、および他社のホスティング"
L_InfopathexeandPropertyPanel="InfoPath.exe、ドキュメント情報パネル、およびワークフロー フォーム"
L_None="なし"
L_MicrosoftIEFeatureControlOptin="Windows Internet Explorer の機能制御の選択"
L_MicrosoftIEFeatureControlOptinExplain="InfoPath は Windows Internet Explorer をホストしています。この設定により、動作をロックダウンする以下の Windows Internet Explorer 機能コントロールのセットが InfoPath で選択されます。\n\nActiveX コントロールのインストール、ファイルのダウンロード、オブジェクトへのバインド、セキュリティ バンド、アドオンの管理、ユーザー名の無効化、MIME 処理、MIME スニッフィング、オブジェクト キャッシュ、ポップアップ ブロック、保存ファイルの確認、URL への移動、ウィンドウの制限、ゾーン昇格。既定では、InfoPath.exe、ドキュメント情報パネル、ワークフロー フォーム、および他社のホスティングに対して機能コントロールのロックダウンがオンになっています。この設定を変更して、InfoPath.exe、ドキュメント情報パネル、およびワークフロー フォームのみに対してオンにしたり、完全にオフにすることもできます。"
L_Neverrun="実行しない"
L_Promptbeforerunning="実行する前にメッセージを表示する"
L_Runwithoutprompting="メッセージを表示せずに実行する"
L_ControlbehaviorwhenopeningInfoPathemailformscontaExplain="この設定では、InfoPath 電子メール フォームを開くときにコードまたはスクリプトを実行するかどうかを指定します。既定では、コードまたはスクリプトを含むフォーム テンプレートを開く前にメッセージが表示されます。ここでメッセージを表示せずにコードまたはスクリプトを実行するように指定すると、ユーザーに確認せずにコードまたはスクリプトを含む InfoPath 電子メール フォームを開きます。スクリプトを実行しないように指定すると、このようなフォームを開く操作がエラーになります。"
L_ControlbehaviorwhenopeningInfoPathemailformsconta="コードまたはスクリプトを含む InfoPath 電子メール フォームを開くときの動作を指定する"
L_PublishtoSharePoint="Windows SharePoint Services または Form Services への発行"
L_DisablesubmitusingrulesExplain="動作規則を使用してデータを送信する新しいフォーム テンプレートをデザインできるようにするかどうかを指定します。"
L_Disablesubmitusingrules="動作規則を使用したデータの送信"
L_DisablesubmitdatausingcodeExplain="コードを使用してデータを送信するフォーム テンプレートをデザインできるようにするかどうかを指定します。"
L_Disablesubmitdatausingcode="コードを使用したデータの送信"
L_DisablesubmitdataviaHTTPExplain="カスタム アプリケーションで Microsoft Office InfoPath Editor Control 2007 をホストできないようにします (このポリシーを使用して、サードパーティのアプリケーションで InfoPath Editor ActiveX コントロールをホストする機能をオフにすることもできます)。"
L_DisablesubmitdataviaHTTP="HTTP でのデータの送信"
L_DisbalesubmitdatatohostingenvironmentExplain="ホスト アプリケーションにデータを送信する新しいフォーム テンプレートをデザインできるようにするかどうかを指定します。"
L_Disbalesubmitdatatohostingenvironment="ホスティング環境への送信"
L_OfflineModecachesizeExplain="InfoPath では、データ ソースのクエリによって返されたデータがキャッシュされます。キャッシュされたデータは、データ ソースにアクセスできないときに使用されます。このポリシーでは、キャッシュされるデータに割り当てるディスク領域の最大サイズを設定します。"
L_OfflineModecachesize="オフライン モードのキャッシュ サイズ"
L_Numberofbytescolon="バイト数:"
L_OfflinedatacachedperformtemplateExplain="InfoPath では、データ ソースのクエリによって返されたデータがキャッシュされます。キャッシュされたデータは、データ ソースにアクセスできないときに使用されます。また、1 つのフォーム テンプレートのすべてのインスタンスにわたってデータがキャッシュされます。このポリシーでは、フォーム テンプレートに対してキャッシュするデータの最大サイズを制御します。"
L_Offlinedatacachedperformtemplate="フォーム テンプレートごとにキャッシュされるオフライン データ"
L_ShowUIifXSNisinInternetZone="XSN がインターネット ゾーンにある場合に UI を表示する"
L_AlwaysshowUI="常に UI を表示する"
L_NeverShowUI="常に UI を表示しない"
L_EmailFormsBeaconingUIExplain="Outlook を使用して開いたフォームで、脅威の発生を知らせるセキュリティ UI を表示するタイミングを制御します。"
L_EmailFormsBeaconingUI="電子メール フォームのビーコン UI"
L_DisablehostingtheMicrosoftOfficeInfoPathEditior="カスタム アプリケーションで Microsoft Office InfoPath Editor Control をホストできないようにします。"
L_DisableMicrosoftOfficeInfoPathEditiorControl="Microsoft Office InfoPath Editor Control を無効にする"
L_DisablesubmitdatatoWebServicesExplain="Web サービスにデータを送信するフォーム テンプレートをデザインできるようにするかどうかを指定します。このポリシーを有効にした場合、Web サービスにデータを送信するフォーム テンプレートを新しく作成することはできません。これは、この機能を使用する既存のフォーム テンプレートを変更できるかどうかには影響しません。このポリシーを無効にした場合、InfoPath のデザイン モードの機能は変更されません。"
L_DisablesubmitdatatoWebServices="Web サービスへのデータの送信"
L_DisablesubmitdatatoSharePointExplain="Windows SharePoint Services サーバーにデータを送信するフォーム テンプレートをデザインできるようにするかどうかを指定します。"
L_DisablesubmitdatatoSharePoint="Windows SharePoint Services へのデータの送信"
L_DisableIRMExplain="このポリシーを有効にした場合、デザイン モードにおいて、Information Rights Management (IRM) で保護されたフォームのデザイン操作が制限されます。"
L_DisableIRM="Information Rights Management"
L_PublishinstallableformtemplatesExplain="このポリシーを有効にすると、インストール可能なフォーム テンプレートを発行できなくなります。"
L_Publishinstallableformtemplates="インストール可能なフォーム テンプレートの発行"
L_Publish="発行"
L_MicrosoftOfficeInfoPath12machine="Microsoft Office InfoPath 2007 (マシン)"
L_SubmitdatatodatabasesExplain="データベースにデータを送信するフォーム テンプレートをデザインできるようにするかどうかを指定します。このポリシーを有効にした場合、データベースにデータを送信するフォーム テンプレートを新しく作成することはできません。これは、この機能を使用する既存のフォーム テンプレートを変更できるかどうかには影響しません。このポリシーを無効にした場合、InfoPath のデザイン モードの機能は変更されません。"
L_Submitdatatodatabases="データベースへのデータの送信"
L_Submit="送信"
L_DataconnectionstoXMLfilesExplain="XML ファイルへのデータ接続を使用するフォーム テンプレートをデザインできるようにするかどうかを指定します。このポリシーを有効にした場合、XML ファイルへのデータ接続を使用するフォーム テンプレートを新しく作成することはできません。これは、データ接続を使用する既存のフォーム テンプレートを変更できるかどうかには影響しません。このポリシーを設定しなかったり、無効にした場合、InfoPath のデザイン モードの機能は変更されません。"
L_DataconnectionstoXMLfiles="XML ファイルへのデータ接続"
L_DataconnectionstoWebservicesExplain="Web サービスへのデータ接続を使用するフォーム テンプレートをデザインできるようにするかどうかを指定します。このポリシーを有効にした場合、Web サービスへのデータ接続を使用するフォーム テンプレートを新しく作成することはできません。これは、データ接続を使用する既存のフォーム テンプレートを変更できるかどうかには影響しません。このポリシーを無効にした場合、InfoPath のデザイン モードの機能は変更されません。"
L_DataconnectionstoWebservices="Web サービスへのデータ接続"
L_DataconnectionstoSharePointExplain="Windows SharePoint Services ライブラリまたはリストへのデータ接続を使用するフォーム テンプレートをデザインできるようにするかどうかを指定します。このポリシーを有効にした場合、Windows SharePoint Services ライブラリへのデータ接続を使用するフォーム テンプレートを新しく作成することはできません。これは、データ接続を使用する既存のフォーム テンプレートを変更できるかどうかには影響しません。このポリシーを無効にした場合、InfoPath のデザイン モードの機能は変更されません。"
L_DataconnectionstoSharePoint="Windows SharePoint Services へのデータ接続"
L_ModifyingthelistofserversExplain="データ接続ファイルを探すためにクエリを実行するサーバーのリストを、フォーム作成者が変更できるようにするかどうかを指定します。このポリシーを有効にした場合、フォーム作成者は、データ接続が検索される Windows SharePoint Services サイトのリストを変更することはできません。これは、データ接続を使用する既存のフォーム テンプレートを変更できるかどうかには影響しません。このポリシーを無効にした場合、InfoPath のデザイン モードの機能は変更されません。"
L_Modifyingthelistofservers="データ接続を探すためにクエリを実行するサーバーのリストの変更"
L_DataConnectionsfromDataConnectionLibraryExplain="データ接続ライブラリからデータ接続を使用するフォーム テンプレートをデザインできるようにするかどうかを指定します。このポリシーを無効にした場合、データ接続ライブラリにあるデータ接続を使用するフォーム テンプレートを新しく作成することはできません。これは、データ接続を使用する既存のフォーム テンプレートを変更できるかどうかには影響しません。このポリシーを無効にした場合、InfoPath のデザイン モードの機能は変更されません。"
L_DataConnectionsfromDataConnectionLibrary="データ接続ライブラリにあるデータ接続"
L_DataConnectionstodatabasesExplain="データベースへのデータ接続を使用するフォーム テンプレートをデザインできるようにするかどうかを指定します。このポリシーを有効にした場合、データベースへのデータ接続を使用するフォーム テンプレートを新しく作成することはできません。これは、データ接続を使用する既存のフォーム テンプレートを変更できるかどうかには影響しません。このポリシーを無効にした場合、InfoPath のデザイン モードの機能は変更されません。"
L_DataConnectionstodatabases="データベースへのデータ接続"
L_DataConnectionsExplain="データ接続を使用するフォーム テンプレートをデザインできるようにするかどうかを指定します。このポリシーを有効にした場合、データ接続を使用するフォーム テンプレートを新しく作成することはできません。これは、データ接続を使用する既存のフォーム テンプレートを変更できるかどうかには影響しません。このポリシーを無効にした場合、InfoPath のデザイン モードの機能は変更されません。"
L_DataConnections="データ接続"
L_Customcodeexplain="ユーザー設定コードを使用するフォーム テンプレートをデザインできるようにするかどうかを指定します。このポリシーを有効にした場合、コードを使用するフォーム テンプレートを新しく作成することはできません。このポリシーを無効にした場合、InfoPath のデザイン モードの機能は変更されません。"
L_DisableCustomcode="ユーザー設定コード"
L_OfflineModestatusexplain="InfoPath でオフライン モードが使用可能かどうかを管理します。[オフライン モード用にクエリをキャッシュする] チェック ボックス ([ツール] メニューの [オプション] をクリックし、[詳細設定] タブをクリック) がオフの場合、このポリシーの値は [使用不可] になります。オフライン モードが使用可能な場合も (ポリシーの値が [使用不可] 以外)、InfoPath が現在オフライン モードであるかどうかが管理されます。"
L_Enablednotinuse="使用可能、InfoPath はオフライン モードではない"
L_Enabledinuse="使用可能、InfoPath はオフライン モード"
L_Disabled="使用不可"
L_OfflineModestatus="オフライン モードの状態"
L_Offline="オフライン"
L_Preventthesefiletypesfrombeingaddedtoforms1="次の種類のファイルをフォームに追加できないようにします。" 
L_Preventthesefiletypesfrombeingaddedtoforms2="例: '.ext' または '.ext, .ex1, .ex2, <...>'" 
L_FileTypes="ファイルの種類:"
L_Allowthesefileswhichwouldnormallybeblockedtobeaddedto1="通常はブロックされる次の種類のファイルをフォームに追加できるようにします。" 
L_Allowthesefileswhichwouldnormallybeblockedtobeaddedto2="例: '.ext' または '.ext, .ex1, .ex2, <...>'" 
L_Waitmilliseconds010000="待機時間: (0 ～ 10,000 ミリ秒)"
L_DirectionColon="方向:"
L_Displayawarningthataformisdigitallysigned="フォームがデジタル署名されているという警告を表示する"
L_DisplayawarningthataformisdigitallysignedExplain="この設定では、デジタル署名されたコンテンツを含む Microsoft Office InfoPath フォームを開くときにメッセージ ダイアログ ボックスを表示するかどうかを指定します。既定では、フォームにデジタル署名が含まれていると、警告メッセージが表示されます。この設定を無効にすると、警告メッセージが表示されなくなります。"
L_Preventusersfromallowingunsafefiletypestobeattachedtoforms="安全でない種類のファイルをユーザーがフォームに添付できないようにする"
L_PreventusersfromallowingunsafefiletypestobeattachedtoformsExplain="安全でない種類のファイルの一覧を [添付ファイル] プロパティ ダイアログ ボックスに表示して、そのような種類のファイルをフォームに添付できないようにします。"
L_Blockspecificfiletypesasattachmentstoforms="フォームへの添付ファイルとして特定の種類のファイルをブロックする"
L_BlockspecificfiletypesasattachmentstoformsExplain="フォームに追加できないファイルの種類を指定します。"
L_Allowfiletypesasattachmentstoforms="フォームへの添付ファイルとして特定の種類のファイルを許可する"
L_AllowfiletypesasattachmentstoformsExplain="フォームに追加できるファイルの種類を指定します。指定した種類は、Microsoft Office InfoPath で許可される標準のファイルの種類に追加されます。"
L_Runformsinrestrictedmodeifthey="発行場所の指定がなく、InfoPath 2003 SP1 以前の機能のみが使用されているフォームを制限モードで実行する"
L_RunformsinrestrictedmodeiftheyExplain="既定では、Microsoft Office InfoPath 2003 で作成された、発行場所の指定がないフォームを InfoPath 2003 SP1 で開くと、フォームはドメイン セキュリティ モードで実行されます。このポリシーを有効にすると、このようなフォームが、ドメイン セキュリティ モードよりも安全な制限されたセキュリティ モードで実行されます。"
L_AllowtheuseofActiveXCustomControlsinInfoPathforms="InfoPath フォームで ActiveX カスタム コントロールを使用できるようにする"
L_AllowtheuseofActiveXCustomControlsinInfoPathformsExplain="Microsoft Office InfoPath フォームのデザイン時および入力時に、ユーザーが ActiveX カスタム コントロールを使用できるようにします。"
L_DisableCommonLanguageRuntimeerrorswhenfillingoutforms="フォームの入力時に共通言語ランタイムのエラーを無効にする"
L_Suppressesexceptionsthrownbyforms="ユーザー設定の Visual Basic または Visual C# コードを使用したフォームから返された例外を表示しないようにします。"
L_AutoRecoverInterval="自動保存の間隔"
L_AutoRecoverIntervalExplain="Microsoft Office InfoPath では、ユーザーがフォームに入力している間、フォームのデータが自動的に保存されます。このオプションでは、自動保存が有効な場合の保存間隔を指定します。"
L_EnableAutoRecover="回復用データの自動保存を有効にする"
L_EnableAutoRecoverExplain="Microsoft Office InfoPath では、ユーザーがフォームに入力している間、フォームのデータを自動的に保存できます。このオプションでは、自動保存を有効にします。"
L_Displayashadedinkguideforhandwriting="手書き認識ガイドを表示する"
L_DisplayashadedinkguideforhandwritingExplain="インク入力時に手書き認識ガイドを有効にします。"
L_Entermillisecondsbeforerecognizinghandwriting="手書き認識を開始するまでの待機時間 (ミリ秒)"
L_EntermillisecondsbeforerecognizinghandwritingExplain="Microsoft Office InfoPath が手書き認識を開始するまでの時間をミリ秒単位で指定します。"
L_DisplaywarningdialogthatuserisenteringtextinInkentrymode="ユーザーがインク入力モードでテキストを入力するときに警告ダイアログ ボックスを表示する"
L_DisplaywarningdialogthatuserisenteringtextinInkentrymodeExplain="警告ダイアログ ボックスを表示して、インク入力が有効になっていることをユーザーに通知します。"
L_InkEntry="インク入力"
L_InkEntryExplain="このオプションを有効にすると、Microsoft Office InfoPath がインク入力モードで起動します。"
L_Entertextdirectionfornewforms="新しいフォームで使用する文字の方向"
L_EntertextdirectionfornewformsExplain="新しいフォームの文字の方向を指定します。フォームには、左から右 (LTR) または右から左 (RTL) のいずれかで入力できます。"
L_Advanced="詳細設定"
L_Ink="インク"
L_Design="デザイン"
L_String=""
L_ControlbehaviorwhenopeningformsintheInternetsecurityzone="インターネットのセキュリティ ゾーンにあるフォームを開くときの動作を指定する"
L_ControlbehaviorwhenopeningformsintheInternetsecurityzoneExplain="このポリシーでは、インターネットのセキュリティ ゾーンで、テンプレート名 (URN) とフォームの場所 (PI の場所) が不一致のフォームを開くときの Microsoft Office InfoPath の動作を指定します。"
L_WhenopeningformsfromtheInternetsecurityzonethat1="インターネットのセキュリティ ゾーンで、テンプレート名 (URN) と" 
L_WhenopeningformsfromtheInternetsecurityzonethat2="フォームの場所 (PI の場所) が不一致のフォームを開くときの動作" 
L_ControlbehaviorwhenopeningformsintheIntranetsecurityzone="イントラネットのセキュリティ ゾーンにあるフォームを開くときの動作を指定する"
L_ControlbehaviorwhenopeningformsintheIntranetsecurityzoneExplain="このポリシーでは、イントラネットのセキュリティ ゾーンで、テンプレート名 (URN) とフォームの場所 (PI の場所) が不一致のフォームを開くときの InfoPath の動作を指定します。"
L_WhenopeningformsfromtheIntranetsecurityzonethat1="イントラネットのセキュリティ ゾーンで、テンプレート名 (URN) と" 
L_WhenopeningformsfromtheIntranetsecurityzonethat2="フォームの場所 (PI の場所) が不一致のフォームを開くときの動作" 
L_ControlbehaviorwhenopeningformsintheLocalMachinesecurityzone="ローカル コンピュータのセキュリティ ゾーンにあるフォームを開くときの動作を指定する"
L_ControlbehaviorwhenopeningformsintheLocalMachinesecurityzoneExplain="このポリシーでは、ローカル コンピュータのセキュリティ ゾーンで、テンプレート名 (URN) とフォームの場所 (PI の場所) が不一致のフォームを開くときの Microsoft Office InfoPath の動作を指定します。"
L_WhenopeningformsfromtheLocalMachinesecurityzonethat1="ローカル コンピュータのセキュリティ ゾーンで、テンプレート名 (URN) と" 
L_WhenopeningformsfromtheLocalMachinesecurityzonethat2="フォームの場所 (PI の場所) が不一致のフォームを開くときの動作" 
L_ControlbehaviorwhenopeningformsintheTrustedSitesecurityzone="信頼済みサイトのセキュリティ ゾーンにあるフォームを開くときの動作を指定する"
L_ControlbehaviorwhenopeningformsintheTrustedSitesecurityzoneExplain="このポリシーでは、信頼済みサイトのセキュリティ ゾーンで、テンプレート名 (URN) とフォームの場所 (PI の場所) が不一致のフォームを開くときの Microsoft Office InfoPath の動作を指定します。"
L_WhenopeningformsfromtheTrustedSitesecurityzonethat1="信頼済みサイトのセキュリティ ゾーンで、テンプレート名 (URN) と" 
L_WhenopeningformsfromtheTrustedSitesecurityzonethat2="フォームの場所 (PI の場所) が不一致のフォームを開くときの動作" 
L_Prompt="確認のメッセージを表示する"
L_Block="ブロックする"
L_Allow="許可する"
L_EnterURLoflocationwhereuserscandownloadFormimporters="フォーム インポータのダウンロード場所の URL"
L_EnterURL="URL を入力してください:"
L_Allowuserstoturnonandoffprintingofbackgroundcolors="背景色を印刷するかどうかをユーザーが切り替えられるようにする"
L_CheckedDisplaysanerroriftheuserattemptstoopenanInfoPathsolut="オンにした場合、ユーザーがインターネットのセキュリティ ゾーンにあるソースから InfoPath ソリューションを開こうとすると、エラーが表示されます。オフにした場合、インターネットのセキュリティ ゾーンにあるソースから InfoPath ソリューションを開くことができます。"
L_DisableInfoPathDesignermode="InfoPath デザイン モードを無効にする"
L_Disablefullytrustedsolutionsfullaccesstomachine="完全に信頼できるソリューションにコンピュータへの完全なアクセス権を与えない"
L_DisableopeningofsolutionsfromtheInternetsecurityzone="インターネットのセキュリティ ゾーンからソリューションを開けないようにする"
L_DisablesEnablestheDesignaFormcommandintheFilemenuandonthetas="[ファイル] メニューおよび作業ウィンドウの [フォーム テンプレートのデザイン] を無効または有効にします。"
L_DisablesEnablestheoptionAllowfullytrustedformstohaveaccessto="[完全に信頼できるフォームをこのコンピュータで実行できるようにする] オプションを無効または有効にします。"
L_EAFind="あいまい検索"
L_Hidespellingerrors="スペル チェックの結果を表示しない"
L_Matchchoonusedforvowels="長音 [ー](母音でのばす音)"
L_Matchfullhalfwidthforms="半角と全角を区別する"
L_Matchminusdashcho="マイナス/長音/ダッシュ [－/ー/-]"
L_MicrosoftOfficeInfoPath12="Microsoft Office InfoPath 2007"
L_No="いいえ"
L_Normal="標準レベル"
L_Numberofentries="ファイルの数:"
L_SelectEAlinebreakingbehavior="日本語の改行時の処理を選択してください"
L_SetEAlinebreaking="日本語の改行時の処理を設定する"
L_SetsthenumberofentriesinthefilelistintheFilemenu="[ファイル] メニューのファイル一覧に表示されるファイルの数を設定します。"
L_SpecifiesanerrormessagetodisplayifthepolicySpecifypathtoInfo="ポリシー ''更新されたバージョンの InfoPath を取得するパスの指定'' が設定されていて、InfoPath の更新が必要なフォームにユーザーがアクセスした場合に表示するエラー メッセージを指定します。エラー メッセージは、そのポリシーで指定された場所から、更新されたバージョンを取得する方法についての情報や指示を提供するために使用できます。"
L_SpecifiesthelocationwhereuserscanobtainanupdatedversionofInf="ユーザーが開こうとしたフォームで、更新されたバージョンの InfoPath が必要な場合に、このバージョンを取得できるパスを指定します。"
L_Specifycustommessageforincompatiblesolutions="互換性がないフォーム テンプレート用のユーザー設定メッセージの指定"
L_Specifymessageforincompatiblesolutions="互換性がないソリューションに表示するメッセージの指定"
L_SpecifypathtoInfoPathupdater="更新されたバージョンの InfoPath を取得するパスの指定"
L_SpellingGrammar="スペル チェックと文章校正"
L_Strict="高レベル"
L_Usedwhenopeningaformtemplatethatis1="現在のバージョンの InfoPath と互換性がない" 
L_Usedwhenopeningaformtemplatethatis2="フォーム テンプレートを開くときに使用されます。" 
L_Yes="はい"
L_YesDisablestheoptionPrintbackgroundcolorsinGeneraltaboftheTo="[はい] を選択した場合、[オプション] ダイアログ ボックス ([ツール] メニューの [オプション] をクリック) の [全般] タブにある [背景色と背景画像を印刷する] オプションがオフになります。[いいえ] を選択した場合、[背景色と背景画像を印刷する] オプションがオンになります。"
L_DefaultFormatPolicy="フォーム テンプレートの既定のファイル形式"
L_DefaultFormatExplain="InfoPath でフォーム テンプレートを保存するのに使用する既定のファイル形式を指定します。"
L_DefaultFormatPart="形式:"
L_DefaultSaveFormat12="InfoPath フォーム テンプレート (*.xsn)"
L_DefaultSaveFormat11="InfoPath 2003 フォーム テンプレート (*.xsn)"
L_EMailFormsCategory="InfoPath 電子メール フォーム"
L_FormTemplatePolicy="電子メール フォームと共にフォーム テンプレートを送信できないようにする"
L_FormTemplateExplain="この設定では、電子メールでの InfoPath フォーム テンプレートの展開方法を指定します。既定では、ユーザーは、フォーム テンプレートをフォームと共に電子メールで送信できます。このポリシーをオンにした場合、ユーザーは、メール メッセージへの添付ファイルとして InfoPath からフォーム テンプレートを送信できなくなります。"
L_DisableCacheXSNPolicy="InfoPath 電子メール フォームでフォーム テンプレートの動的キャッシュを無効にする"
L_DisableCacheXSNExplain="この設定では、InfoPath 電子メール フォームに添付されたテンプレートを展開する方法を指定します。既定では、フォーム テンプレートは、InfoPath 電子メール フォームとして認識されるメール アイテムに添付された場合、InfoPath でキャッシュされます。この設定を無効にした場合、メール アイテムに添付されたフォーム テンプレートは InfoPath でキャッシュされず、発行された場所でのみフォーム テンプレートがキャッシュされます。"
L_DisableEmailFormsPolicy="InfoPath 2003 フォームを電子メール フォームとして送信できないようにする"
L_DisableEmailFormsExplain="このポリシーでは、InfoPath 2003 と互換性のあるフォームを電子メールで送信する方法を指定します。既定では、すべてのフォームは、Outlook との InfoPath 電子メール フォーム統合を使用して電子メールで送信されます。この設定をオンにした場合、InfoPath 2003 と互換性のあるフォームは、電子メール フォーム統合を使用して送信されません。"
L_RestrictedEmailFormsPolicy="制限されたセキュリティ レベルで実行される電子メール フォームを無効にする"
L_RestrictedEmailFormsExplain="この設定では、InfoPath 電子メール フォームが実行されるセキュリティ コンテキストを指定します。既定では、InfoPath の制限されたセキュリティ レベルで実行される InfoPath 電子メール フォームを開くことができます。このポリシーを有効にした場合、InfoPath の制限されたセキュリティ レベルでは InfoPath 電子メール フォームを読み込めなくなり、ポリシーによって機能が無効にされていることを示すエラー メッセージが表示されます。"
L_DisableInternetEmailFormsPolicy="インターネットのセキュリティ ゾーンで電子メール フォームを無効にする"
L_DisableInternetEmailFormsExplain="このポリシーでは、InfoPath 電子メール フォームが実行されるセキュリティ コンテキストを指定します。既定では、インターネットのセキュリティ ゾーンで実行される InfoPath 電子メール フォームを開くことができます。このポリシーを有効にした場合、インターネットのセキュリティ ゾーンでは InfoPath 電子メール フォームを読み込めなくなり、ポリシーによって機能が無効にされていることを示すエラー メッセージが表示されます。"
L_DisableIntranetEmailFormsPolicy="イントラネットのセキュリティ ゾーンで電子メール フォームを無効にする"
L_DisableIntranetEmailFormsExplain="このポリシーでは、InfoPath 電子メール フォームが実行されるセキュリティ コンテキストを指定します。既定では、イントラネットのセキュリティ ゾーンで実行される InfoPath 電子メール フォームを開くことができます。このポリシーを有効にした場合、イントラネットのセキュリティ ゾーンでは InfoPath 電子メール フォームを読み込めなくなり、ポリシーによって機能が無効にされていることを示すエラー メッセージが表示されます。"
L_DisableFullTrustEmailFormsPolicy="完全信頼のセキュリティ ゾーンで電子メール フォームを無効にする"
L_DisableFullTrustEmailFormsExplain="このポリシーでは、InfoPath 電子メール フォームが実行されるセキュリティ コンテキストを指定します。既定では、完全信頼のセキュリティ ゾーンで実行される InfoPath 電子メール フォームを開くことができます。このポリシーを有効にした場合、完全信頼のセキュリティ ゾーンでは InfoPath 電子メール フォームを読み込めなくなり、ポリシーによって機能が無効にされていることを示すエラー メッセージが表示されます。"
L_DisableOutlookEmailFormsPolicy="Outlook で InfoPath 電子メール フォームを無効にする"
L_DisableOutlookEmailFormsExplain="この設定では、Outlook で InfoPath フォームをレンダリングする方法を指定します。既定では、InfoPath 電子メール フォーム機能を使用して、Outlook でフォームがレンダリングされ、フォームにデータが入力されます。このポリシーを有効にした場合、Outlook では、InfoPath フォームが添付ファイルのある電子メール メッセージとしてレンダリングされ、InfoPath 電子メール フォーム固有の動作はすべて無効になります。"
L_DisableExporttoExcelEmailFormsPolicy="InfoPath 電子メール フォームを Excel にエクスポートできないようにする"
L_DisableExporttoExcelEmailFormsExplain="このポリシーでは、InfoPath 電子メール フォームを Excel にエクスポートできるようにするかどうかを指定します。既定では、Outlook の InfoPath 電子メール フォームをエクスポートして、Excel 形式の XML リストを作成できます。この設定を有効にした場合、InfoPath 電子メール フォームを Outlook から Excel にエクスポートすることはできません。"
L_DisableMergeEmailFormsPolicy="InfoPath 電子メール フォームを結合できないようにする"
L_DisableMergeEmailFormsExplain="このポリシーでは、InfoPath で InfoPath 電子メール フォームを結合できるようにするかどうかを指定します。既定では、Outlook の InfoPath 電子メール フォームは、1 つの InfoPath フォームとして結合できます。このポリシーを有効にした場合、Outlook から InfoPath 電子メール フォームを結合することはできません。"
L_DisableExportEmailFormsPolicy="InfoPath 電子メール フォームをエクスポートできないようにする"
L_DisableExportEmailFormsExplain="この設定では、InfoPath 電子メール フォームを Outlook からエクスポートできるようにするかどうかを指定します。既定では、Outlook の InfoPath 電子メール フォームは、ファイル フォルダまたはネットワークの別の場所にエクスポートできます。このポリシーを有効にした場合、Outlook からフォームをエクスポートすることはできません。"
L_DisablePropertyPromoEmailFormsPolicy="InfoPath 電子メール フォームのプロパティの共有を無効にする"
L_DisablePropertyPromoEmailFormsExplain="このポリシーでは、Outlook フォルダでフォームのデータを列として共有できるようにするかどうかを指定します。既定では、Outlook の InfoPath フォームのフォルダ内にある InfoPath 電子メール フォームは、個々のフォームのデータをプロパティとして共有できます。このポリシーを有効にした場合、InfoPath 電子メール フォームではフォームのデータをプロパティとして共有できません。"
L_BeaconingUIPolicy="InfoPath でフォームを開く場合のビーコン UI"
L_BeaconingUIExplain="脅威の発生を知らせるセキュリティ UI を表示するタイミングを制御します。"
L_BeaconingUIPart="InfoPath でフォームを開く場合のビーコン UI"
L_BeaconNever="常にビーコン UI を表示しない"
L_BeaconAlways="常にビーコン UI を表示する"
L_BeaconSome="インターネット上のフォーム テンプレートで UI を表示する"
L_ActiveXBeaconingUIPolicy="InfoPath Editor ActiveX でフォームを開く場合のビーコン UI"
L_ActiveXBeaconingUIExplain="InfoPath Editor ActiveX でフォームを開く場合に、脅威の発生を知らせるセキュリティ UI を表示するタイミングを制御します。"
L_ActiveXBeaconingUIPart="InfoPath Editor ActiveX でフォームを開く場合のビーコン UI"
L_ActiveXBeaconNever="常にビーコン UI を表示しない"
L_ActiveXBeaconAlways="常にビーコン UI を表示する"
L_ActiveXBeaconSome="インターネット上のフォーム テンプレートで UI を表示する"
L_RestrictedFeatures="機能の制限"
L_Thissettingcontrolswhetherformtemplates="このポリシーを有効にすると、Forms Services がインストール済みまたは未インストールの Microsoft Office Windows SharePoint Services サイトにフォーム テンプレートを発行できなくなります。"
L_DisablePublishEmailPolicy="電子メールでの発行"
L_DisablePublishEmailExplain="このポリシーを有効にすると、フォーム テンプレートを電子メールで発行できなくなります。"
L_DisablePublishPropertyPolicy="ドキュメント情報パネルとしての発行"
L_DisablePublishPropertyExplain="このポリシーを有効にすると、フォーム テンプレートをドキュメント情報パネルとして発行できなくなります。"
L_DisableSubmitMasterPolicy="データの送信 (マスタ スイッチ)"
L_DisableSubmitMasterExplain="このポリシーにより、データを送信するフォームをユーザーがデザインできないようにします (既定では、デザインできます)。このキーは、'データベースへのデータの送信' や 'Windows SharePoint Services へのデータの送信' などの詳細なポリシーのキーよりも優先されます。この機能を使用する既存のテンプレートを変更できるかどうかには影響しません。"
L_DisableSubmitEmailPolicy="電子メールでのデータ送信"
L_DisableSubmitEmailExplain="電子メールでのデータ送信を実行するフォーム テンプレートをデザインできるようにするかどうかを指定します。このポリシーを有効にした場合、電子メールでの送信を実行するフォーム テンプレートを新しく作成することはできません。これは、この機能を使用する既存のフォーム テンプレートを変更できるかどうかには影響しません。このポリシーを無効にした場合、InfoPath のデザイン モードの機能は変更されません。"


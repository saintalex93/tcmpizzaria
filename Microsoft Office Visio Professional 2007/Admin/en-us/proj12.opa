;// _lcid="1033" _version="12.0.4518"
CLASS USER

CATEGORY !!L_Proj
CATEGORY !!L_PjTools
CATEGORY !!L_Security
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Security"
POLICY !!L_EnableuntrustedintranetzoneaccesstoProjectServer 
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Security"
				VALUENAME TrustWSS
				VALUEON NUMERIC 1
				VALUEOFF NUMERIC 0
	EXPLAIN !!L_EnableuntrustedintranetzoneaccesstoProjectServerExplain 
	END POLICY
END CATEGORY
CATEGORY !!L_PjView
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\View"
POLICY !!L_ProjectSummaryTask 
KEYNAME "Software\Microsoft\office\12.0\MS Project\Options\View"
				VALUENAME "Show Project Summary"
				VALUEON NUMERIC 1
				VALUEOFF NUMERIC 0
	EXPLAIN !!L_ProjectSummaryTaskExplain 
	END POLICY
POLICY !!L_PjDefaultView
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\View\1033"
	PART !!L_PjDefaultView DROPDOWNLIST
					VALUENAME "Default View"
	ITEMLIST
						NAME !!L_PjView0		VALUE "Bar Rollup"
						NAME !!L_PjView1		VALUE "Calendar"
						NAME !!L_PjView2		VALUE "Descriptive Network Diagram"
						NAME !!L_PjView3		VALUE "Detail Gantt"
						NAME !!L_PjView4		VALUE "Gantt Chart"	DEFAULT
						NAME !!L_PjView5		VALUE "Leveling Gantt"
						NAME !!L_PjView6		VALUE "Milestone Date Rollup"
						NAME !!L_PjView7		VALUE "Milestone Rollup"
						NAME !!L_PjView8		VALUE "Network Diagram"
						NAME !!L_PjView9		VALUE "Relationship Diagram"
						NAME !!L_PjView10		VALUE "Resource Allocation"
						NAME !!L_PjView11		VALUE "Resource Form"
						NAME !!L_PjView12		VALUE "Resource Graph"
						NAME !!L_PjView13		VALUE "Resource Name Form"
						NAME !!L_PjView14		VALUE "Resource Sheet"
						NAME !!L_PjView15		VALUE "Resource Usage"
						NAME !!L_PjView16		VALUE "Task Details Form"
						NAME !!L_PjView17		VALUE "Task Entry"
						NAME !!L_PjView18		VALUE "Task Form"
						NAME !!L_PjView19		VALUE "Task Name Form"
						NAME !!L_PjView20		VALUE "Task Sheet"
						NAME !!L_PjView21		VALUE "Task Usage"
						NAME !!L_PjView22		VALUE "Tracking Gantt"
	END ITEMLIST
					NOSORT
	END PART
	EXPLAIN !!L_PjDefaultViewExplain
	END POLICY
POLICY !!L_PjDateFormat
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\View"
	PART !!L_PjDateFormat DROPDOWNLIST
					VALUENAME "Date Format"
	ITEMLIST
						NAME !!L_PjDate0		VALUE NUMERIC 0
						NAME !!L_PjDate1		VALUE NUMERIC 1
						NAME !!L_PjDate20		VALUE NUMERIC 20
						NAME !!L_PjDate2		VALUE NUMERIC 2
						NAME !!L_PjDate3		VALUE NUMERIC 3
						NAME !!L_PjDate4		VALUE NUMERIC 4
						NAME !!L_PjDate5		VALUE NUMERIC 5
						NAME !!L_PjDate6		VALUE NUMERIC 6
						NAME !!L_PjDate7		VALUE NUMERIC 7
						NAME !!L_PjDate8		VALUE NUMERIC 8 
						NAME !!L_PjDate9		VALUE NUMERIC 9	DEFAULT
						NAME !!L_PjDate10		VALUE NUMERIC 10
						NAME !!L_PjDate11		VALUE NUMERIC 11
						NAME !!L_PjDate15		VALUE NUMERIC 15
						NAME !!L_PjDate16		VALUE NUMERIC 16
						NAME !!L_PjDate17		VALUE NUMERIC 17
						NAME !!L_PjDate12		VALUE NUMERIC 12
						NAME !!L_PjDate13		VALUE NUMERIC 13
						NAME !!L_PjDate14		VALUE NUMERIC 14
						NAME !!L_PjDate18		VALUE NUMERIC 18
						NAME !!L_PjDate19		VALUE NUMERIC 19
	END ITEMLIST
					NOSORT
	END PART
	EXPLAIN !!L_PjDateFormatExplain
	END POLICY
POLICY !!L_DefaultProjectCurrency 
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\View"
	PART !!L_DefaultProjectCurrency DROPDOWNLIST
					VALUENAME Currency
	ITEMLIST
						NAME !!L_UnitedArabEmiratesDirhams                          VALUE "AED" DEFAULT
						NAME !!L_AfghanistanAfghanis                                VALUE "AFA"
						NAME !!L_AlbaniaLeke                                        VALUE "ALL"
						NAME !!L_ArmeniaDrams                                       VALUE "AMD"
						NAME !!L_NetherlandsAntillesGuilders                        VALUE "ANG"
						NAME !!L_AngolaKwanza                                       VALUE "AOA"
						NAME !!L_ArgentinaPesos                                     VALUE "ARS"
						NAME !!L_AustraliaDollars                                   VALUE "AUD"
						NAME !!L_ArubaGuilders_alsocalledFlorins                    VALUE "AWG"
						NAME !!L_AzerbaijanManats                                   VALUE "AZM"
						NAME !!L_BosniaandHerzegovinaConvertibleMarka               VALUE "BAM"
						NAME !!L_BarbadosDollars                                    VALUE "BBD"
						NAME !!L_BangladeshTaka                                     VALUE "BDT"
						NAME !!L_BulgariaLeva                                       VALUE "BGN"
						NAME !!L_BahrainDinars                                      VALUE "BHD"
						NAME !!L_BurundiFrancs                                      VALUE "BIF"
						NAME !!L_BermudaDollars                                     VALUE "BMD"
						NAME !!L_BruneiDarussalamDollars                            VALUE "BND"
						NAME !!L_BoliviaBolivianos                                  VALUE "BOB"
						NAME !!L_BrazilBrazilReal                                   VALUE "BRL"
						NAME !!L_BahamasDollars                                     VALUE "BSD"
						NAME !!L_BhutanNgultrum                                     VALUE "BTN"
						NAME !!L_BotswanaPulas                                      VALUE "BWP"
						NAME !!L_BelarusRubles                                      VALUE "BYR"
						NAME !!L_BelizeDollars                                      VALUE "BZD"
						NAME !!L_CanadaDollars                                      VALUE "CAD"
						NAME !!L_CongoKinshasaCongoleseFrancs                       VALUE "CDF"
						NAME !!L_SwitzerlandFrancs                                  VALUE "CHF"
						NAME !!L_ChilePesos                                         VALUE "CLP"
						NAME !!L_ChinaYuanRenminbi                                  VALUE "CNY"
						NAME !!L_ColombiaPesos                                      VALUE "COP"
						NAME !!L_CostaRicaColones                                   VALUE "CRC"
						NAME !!L_SerbiaDinars                                       VALUE "CSD"
						NAME !!L_CubaPesos                                          VALUE "CUP"
						NAME !!L_CapeVerdeEscudos                                   VALUE "CVE"
						NAME !!L_CyprusPounds                                       VALUE "CYP"
						NAME !!L_CzechRepublicKoruny                                VALUE "CZK"
						NAME !!L_DjiboutiFrancs                                     VALUE "DJF"
						NAME !!L_DenmarkKroner                                      VALUE "DKK"
						NAME !!L_DominicanRepublicPesos                             VALUE "DOP"
						NAME !!L_AlgeriaAlgeriaDinars                               VALUE "DZD"
						NAME !!L_EstoniaKrooni                                      VALUE "EEK"
						NAME !!L_EgyptPounds                                        VALUE "EGP"
						NAME !!L_EritreaNakfa                                       VALUE "ERN"
						NAME !!L_EthiopiaBirr                                       VALUE "ETB"
						NAME !!L_EuroMemberCountriesEuro                            VALUE "EUR"
						NAME !!L_FijiDollars                                        VALUE "FJD"
						NAME !!L_FalklandIslands_Malvinas_Pounds                    VALUE "FKP"
						NAME !!L_UnitedKingdomPounds                                VALUE "GBP"
						NAME !!L_GeorgiaLari                                        VALUE "GEL"
						NAME !!L_GuernseyPounds                                     VALUE "GGP"
						NAME !!L_GhanaCedis                                         VALUE "GHC"
						NAME !!L_GibraltarPounds                                    VALUE "GIP"
						NAME !!L_GambiaDalasi                                       VALUE "GMD"
						NAME !!L_GuineaFrancs                                       VALUE "GNF"
						NAME !!L_GuatemalaQuetzales                                 VALUE "GTQ"
						NAME !!L_GuyanaDollars                                      VALUE "GYD"
						NAME !!L_HongKongDollars                                    VALUE "HKD"
						NAME !!L_HondurasLempiras                                   VALUE "HNL"
						NAME !!L_CroatiaKuna                                        VALUE "HRK"
						NAME !!L_HaitiGourdes                                       VALUE "HTG"
						NAME !!L_HungaryForint                                      VALUE "HUF"
						NAME !!L_IndonesiaRupiahs                                   VALUE "IDR"
						NAME !!L_IsraelNewShekels                                   VALUE "ILS"
						NAME !!L_IsleofManPounds                                    VALUE "IMP"
						NAME !!L_IndiaRupees                                        VALUE "INR"
						NAME !!L_IraqDinars                                         VALUE "IQD"
						NAME !!L_IranRials                                          VALUE "IRR"
						NAME !!L_IcelandKronur                                      VALUE "ISK"
						NAME !!L_JerseyPounds                                       VALUE "JEP"
						NAME !!L_JamaicaDollars                                     VALUE "JMD"
						NAME !!L_JordanDinars                                       VALUE "JOD"
						NAME !!L_JapanYen                                           VALUE "JPY"
						NAME !!L_KenyaShillings                                     VALUE "KES"
						NAME !!L_KyrgyzstanSoms                                     VALUE "KGS"
						NAME !!L_CambodiaRiels                                      VALUE "KHR"
						NAME !!L_ComorosFrancs                                      VALUE "KMF"
						NAME !!L_Korea_North_Won                                    VALUE "KPW"
						NAME !!L_Korea_South_Won                                    VALUE "KRW"
						NAME !!L_KuwaitDinars                                       VALUE "KWD"
						NAME !!L_CaymanIslandsDollars                               VALUE "KYD"
						NAME !!L_KazakhstanTenge                                    VALUE "KZT"
						NAME !!L_LaosKips                                           VALUE "LAK"
						NAME !!L_LebanonPounds                                      VALUE "LBP"
						NAME !!L_SriLankaRupees                                     VALUE "LKR"
						NAME !!L_LiberiaDollars                                     VALUE "LRD"
						NAME !!L_LesothoMaloti                                      VALUE "LSL"
						NAME !!L_LithuaniaLitai                                     VALUE "LTL"
						NAME !!L_LatviaLati                                         VALUE "LVL"
						NAME !!L_LibyaDinars                                        VALUE "LYD"
						NAME !!L_MoroccoDirhams                                     VALUE "MAD"
						NAME !!L_MoldovaLei                                         VALUE "MDL"
						NAME !!L_MadagascarAriary                                   VALUE "MGA"
						NAME !!L_MacedoniaDenars                                    VALUE "MKD"
						NAME !!L_Myanmar_Burma_Kyats                                VALUE "MMK"
						NAME !!L_MongoliaTugriks                                    VALUE "MNT"
						NAME !!L_MacauPatacas                                       VALUE "MOP"
						NAME !!L_MauritaniaOuguiyas                                 VALUE "MRO"
						NAME !!L_MaltaLiri                                          VALUE "MTL"
						NAME !!L_MauritiusRupees                                    VALUE "MUR"
						NAME !!L_Maldives_MaldiveIslands_Rufiyaa                    VALUE "MVR"
						NAME !!L_MalawiKwachas                                      VALUE "MWK"
						NAME !!L_MexicoPesos                                        VALUE "MXN"
						NAME !!L_MalaysiaRinggits                                   VALUE "MYR"
						NAME !!L_MozambiqueMeticais                                 VALUE "MZM"
						NAME !!L_NamibiaDollars                                     VALUE "NAD"
						NAME !!L_NigeriaNairas                                      VALUE "NGN"
						NAME !!L_NicaraguaCordobas                                  VALUE "NIO"
						NAME !!L_NorwayKrone                                        VALUE "NOK"
						NAME !!L_NepalNepalRupees                                   VALUE "NPR"
						NAME !!L_NewZealandDollars                                  VALUE "NZD"
						NAME !!L_OmanRials                                          VALUE "OMR"
						NAME !!L_PanamaBalboa                                       VALUE "PAB"
						NAME !!L_PeruNuevosSoles                                    VALUE "PEN"
						NAME !!L_PapuaNewGuineaKina                                 VALUE "PGK"
						NAME !!L_PhilippinesPesos                                   VALUE "PHP"
						NAME !!L_PakistanRupees                                     VALUE "PKR"
						NAME !!L_PolandZlotych                                      VALUE "PLN"
						NAME !!L_ParaguayGuarani                                    VALUE "PYG"
						NAME !!L_QatarRials                                         VALUE "QAR"
						NAME !!L_RomaniaNewLei                                      VALUE "RON"
						NAME !!L_RussiaRubles                                       VALUE "RUB"
						NAME !!L_RwandaRwandaFrancs                                 VALUE "RWF"
						NAME !!L_SaudiArabiaRiyals                                  VALUE "SAR"
						NAME !!L_SolomonIslandsDollars                              VALUE "SBD"
						NAME !!L_SeychellesRupees                                   VALUE "SCR"
						NAME !!L_SudanDinars                                        VALUE "SDD"
						NAME !!L_SwedenKronor                                       VALUE "SEK"
						NAME !!L_SingaporeDollars                                   VALUE "SGD"
						NAME !!L_SaintHelenaPounds                                  VALUE "SHP"
						NAME !!L_SloveniaTolars                                     VALUE "SIT"
						NAME !!L_SlovakiaKoruny                                     VALUE "SKK"
						NAME !!L_SierraLeoneLeones                                  VALUE "SLL"
						NAME !!L_SomaliaShillings                                   VALUE "SOS"
						NAME !!L_SeborgaLuigini                                     VALUE "SPL"
						NAME !!L_SurinameDollars                                    VALUE "SRD"
						NAME !!L_SaoTomeandPrincipeDobras                           VALUE "STD"
						NAME !!L_ElSalvadorColones                                  VALUE "SVC"
						NAME !!L_SyriaPounds                                        VALUE "SYP"
						NAME !!L_SwazilandEmalangeni                                VALUE "SZL"
						NAME !!L_ThailandBaht                                       VALUE "THB"
						NAME !!L_TajikistanSomoni                                   VALUE "TJS"
						NAME !!L_TurkmenistanManats                                 VALUE "TMM"
						NAME !!L_TunisiaDinars                                      VALUE "TND"
						NAME !!L_TongaPaanga                                        VALUE "TOP"
						NAME !!L_TurkeyLiras                                        VALUE "TRL"
						NAME !!L_TurkeyNewLira                                      VALUE "TRY"
						NAME !!L_TrinidadandTobagoDollars                           VALUE "TTD"
						NAME !!L_TuvaluTuvaluDollars                                VALUE "TVD"
						NAME !!L_TaiwanNewDollars                                   VALUE "TWD"
						NAME !!L_TanzaniaShillings                                  VALUE "TZS"
						NAME !!L_UkraineHryvnia                                     VALUE "UAH"
						NAME !!L_UgandaShillings                                    VALUE "UGX"
						NAME !!L_UnitedStatesofAmericaDollars                       VALUE "USD"
						NAME !!L_UruguayPesos                                       VALUE "UYU"
						NAME !!L_UzbekistanSums                                     VALUE "UZS"
						NAME !!L_VenezuelaBolivares                                 VALUE "VEB"
						NAME !!L_VietNamDong                                        VALUE "VND"
						NAME !!L_VanuatuVatu                                        VALUE "VUV"
						NAME !!L_SamoaTala                                          VALUE "WST"
						NAME !!L_CommunauteFinanciereAfricaineBEACFrancs            VALUE "XAF"
						NAME !!L_SilverOunces                                       VALUE "XAG"
						NAME !!L_GoldOunces                                         VALUE "XAU"
						NAME !!L_EastCaribbeanDollars                               VALUE "XCD"
						NAME !!L_InternationalMonetaryFund_IMF_SpecialDrawingRights VALUE "XDR"
						NAME !!L_CommunauteFinanciereAfricaineBCEAOFrancs           VALUE "XOF"
						NAME !!L_PalladiumOunces                                    VALUE "XPD"
						NAME !!L_ComptoirsFrancaisduPacifiqueFrancs                 VALUE "XPF"
						NAME !!L_PlatinumOunces                                     VALUE "XPT"
						NAME !!L_YemenRials                                         VALUE "YER"
						NAME !!L_SouthAfricaRand                                    VALUE "ZAR"
						NAME !!L_ZambiaKwacha                                       VALUE "ZMK"
						NAME !!L_ZimbabweZimbabweDollars                            VALUE "ZWD"
	END ITEMLIST
					NOSORT
	END PART
	EXPLAIN !!L_MultiCurrencyExplain
	END POLICY
CATEGORY !!L_CalendarType 
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\View"
POLICY !!L_CalendarType 
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\View"
	PART !!L_CalendarType DROPDOWNLIST
						VALUENAME "Calendar Type"
	ITEMLIST
							NAME !!L_GregorianCalndar  VALUE NUMERIC 1 DEFAULT
							NAME !!L_HirjriCalendar  VALUE NUMERIC 6
							NAME !!L_ThaiBuddhist  VALUE NUMERIC 7
	END ITEMLIST
						NOSORT
	END PART
	EXPLAIN !!L_CalendarTypeExplain
	END POLICY
END CATEGORY
CATEGORY !!L_PjShow
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\View"
POLICY !!L_PjStatusBar
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\View"
					VALUENAME "Show Status Bar"
					VALUEON NUMERIC 1
					VALUEOFF NUMERIC 0 
	EXPLAIN !!L_PjStatusBarExplain
	END POLICY
POLICY !!L_PjWindowsinStatusBar
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\View"
					VALUENAME "Show Windows In Taskbar"
					VALUEON NUMERIC 1
					VALUEOFF NUMERIC 0 
	EXPLAIN !!L_PjWindowsinStatusBarExplain
	END POLICY
POLICY !!L_PjScrollBar
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\View"
					VALUENAME "Show Scroll Bars"
					VALUEON NUMERIC 1
					VALUEOFF NUMERIC 0 
	EXPLAIN !!L_PjScrollBarExplain
	END POLICY
POLICY !!L_PjEntryBar
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\View"
					VALUENAME "Show Entry Bar"
					VALUEON NUMERIC 1
					VALUEOFF NUMERIC 0 
	EXPLAIN !!L_PjEntryBarExplain
	END POLICY
POLICY !!L_PjOLElinks
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\View"
					VALUENAME "Show OLE Link Indicators"
					VALUEON NUMERIC 1
					VALUEOFF NUMERIC 0 
	EXPLAIN !!L_PjOLElinksExplain
	END POLICY
POLICY !!L_PjProjectScreentips
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\View"
					VALUENAME "Show Tooltips"
					VALUEON NUMERIC 1
					VALUEOFF NUMERIC 0 
	EXPLAIN !!L_PjProjectScreentipsExplain
	END POLICY
END CATEGORY
END CATEGORY
CATEGORY !!L_PjGeneral
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\General"
POLICY !!L_UndoLevels
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\General"
	PART !!L_UndoLevels NUMERIC
					VALUENAME UndoLevels
					SPIN 1
					MIN 1
					MAX 99
					DEFAULT 20
	END PART
	EXPLAIN !!L_UndoLevelsExplain
	END POLICY
CATEGORY !!L_PjGeneralProjOptions
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\General"
POLICY !!L_PjOpenLast
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\General"
					VALUENAME "Start With Last File"
					VALUEON NUMERIC 1
					VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjOpenLastExplain
	END POLICY
POLICY !!L_PjPromptForInfo
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\General"
					VALUENAME "Ask for Summary Info at New"
					VALUEON NUMERIC 1
					VALUEOFF NUMERIC 0 
	EXPLAIN !!L_PjPromptForInfoExplain
	END POLICY
POLICY !!L_PjSetAutoFilter 
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\General"
					VALUENAME "Set AutoFilter On for New Projects"
					VALUEON NUMERIC 1
					VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjSetAutoFilterExplain
	END POLICY
POLICY !!L_PjRecentlyUsed
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\General"
	PART !!L_PjMRUT NUMERIC
						VALUENAME DefFileMRU
						SPIN 1
						MIN 1
						MAX 9
						DEFAULT 4
	END PART
	EXPLAIN !!L_PjRecentlyUsedExplain
	END POLICY
END CATEGORY
CATEGORY !!L_PjGeneralOptions
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\General"
POLICY !!L_PjAutoAddNew
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\General"
					VALUENAME "Auto Add Resources"
					VALUEON NUMERIC 1
					VALUEOFF NUMERIC 0 
	EXPLAIN !!L_PjAutoAddNewExplain
	END POLICY
POLICY !!L_PjDefaultStdRate
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\General"
	PART !!L_PjDefaultStdRate EDITTEXT
						VALUENAME "Std. Rate"
						DEFAULT !!L_PjDefStdRateNum
	END PART
	EXPLAIN !!L_PjDefaultStdRateExplain
	END POLICY
POLICY !!L_PjDefaultOtime
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\General"
	PART !!L_PjDefaultOtime EDITTEXT
						VALUENAME "Ovt. Rate"
						DEFAULT !!L_PjDefOtRateNum
	END PART
	EXPLAIN !!L_PjDefaultOtimeExplain
	END POLICY
END CATEGORY
END CATEGORY
CATEGORY !!L_PjEdit
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Edit"
CATEGORY !!L_PjEditOptionsProj
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Edit"
POLICY !!L_PjAllowCellDragDrop
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Edit"
					VALUENAME "Drag And Drop"
					VALUEON NUMERIC 1
					VALUEOFF NUMERIC 0 
	EXPLAIN !!L_PjAllowCellDragDropExplain
	END POLICY
POLICY !!L_PjMoveAfterEnter
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Edit"
					VALUENAME EnterMove
					VALUEON NUMERIC 1
					VALUEOFF NUMERIC 0 
	EXPLAIN !!L_PjMoveAfterEnterExplain
	END POLICY
POLICY !!L_PjAsktoUpdate
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Edit"
					VALUENAME "Prompt for Update Links"
					VALUEON NUMERIC 1
					VALUEOFF NUMERIC 0 
	EXPLAIN !!L_PjAsktoUpdateExplain
	END POLICY
POLICY !!L_PjEditDirectlyCell
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Edit"
					VALUENAME InCellEdit
					VALUEON NUMERIC 1
					VALUEOFF NUMERIC 0 
	EXPLAIN !!L_PjEditDirectlyCellExplain
	END POLICY
END CATEGORY
CATEGORY !!L_PjViewOptions
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Edit"
POLICY !!L_PjMinutes
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Edit"
	PART !!L_PjMinutes DROPDOWNLIST
						VALUENAME MinuteLabelDisplay
	ITEMLIST
							NAME !!L_PjMin0		VALUE NUMERIC 0
							NAME !!L_PjMin1		VALUE NUMERIC 1		DEFAULT
							NAME !!L_PjMin2		VALUE NUMERIC 2
							NAME !!L_PjMin3		VALUE NUMERIC 3
							NAME !!L_PjMin4		VALUE NUMERIC 4
	END ITEMLIST
						NOSORT
	END PART
	EXPLAIN !!L_PjMinutesExplain
	END POLICY
POLICY !!L_PjHours
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Edit"
	PART !!L_PjHours DROPDOWNLIST
						VALUENAME HourLabelDisplay
	ITEMLIST
							NAME !!L_PjHr0		VALUE NUMERIC 0
							NAME !!L_PjHr1		VALUE NUMERIC 1		DEFAULT
							NAME !!L_PjHr2		VALUE NUMERIC 2
							NAME !!L_PjHr3		VALUE NUMERIC 3
							NAME !!L_PjHr4		VALUE NUMERIC 4
	END ITEMLIST
						NOSORT
	END PART
	EXPLAIN !!L_PjHoursExplain
	END POLICY
POLICY !!L_PjDays
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Edit"
	PART !!L_PjDays DROPDOWNLIST
						VALUENAME DayLabelDisplay
	ITEMLIST
							NAME !!L_PjDay0		VALUE NUMERIC 0
							NAME !!L_PjDay1		VALUE NUMERIC 1
							NAME !!L_PjDay2		VALUE NUMERIC 2		DEFAULT
							NAME !!L_PjDay3		VALUE NUMERIC 3
							NAME !!L_PjDay4		VALUE NUMERIC 4
	END ITEMLIST
						NOSORT
	END PART
	EXPLAIN !!L_PjDaysExplain
	END POLICY
POLICY !!L_PjWeeks
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Edit"
	PART !!L_PjDays DROPDOWNLIST
						VALUENAME WeekLabelDisplay
	ITEMLIST
							NAME !!L_PjWk0		VALUE NUMERIC 0
							NAME !!L_PjWk1		VALUE NUMERIC 1		DEFAULT
							NAME !!L_PjWk2		VALUE NUMERIC 2
							NAME !!L_PjWk3		VALUE NUMERIC 3
							NAME !!L_PjWk4		VALUE NUMERIC 4
	END ITEMLIST
						NOSORT
	END PART
	EXPLAIN !!L_PjWeeksExplain
	END POLICY
POLICY !!L_PjMonths
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Edit"
	PART !!L_PjDays DROPDOWNLIST
						VALUENAME MonthLabelDisplay
	ITEMLIST
							NAME !!L_PjM0		VALUE NUMERIC 0
							NAME !!L_PjM1		VALUE NUMERIC 1		DEFAULT
							NAME !!L_PjM2		VALUE NUMERIC 2
							NAME !!L_PjM3		VALUE NUMERIC 3
							NAME !!L_PjM4		VALUE NUMERIC 4
	END ITEMLIST
						NOSORT
	END PART
	EXPLAIN !!L_PjMonthsExplain
	END POLICY
POLICY !!L_PjYears
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Edit"
	PART !!L_PjYears DROPDOWNLIST
						VALUENAME YearLabelDisplay
	ITEMLIST
							NAME !!L_PjYr0		VALUE NUMERIC 0
							NAME !!L_PjYr1		VALUE NUMERIC 1		DEFAULT
							NAME !!L_PjYr2		VALUE NUMERIC 2
							NAME !!L_PjYr3		VALUE NUMERIC 3
							NAME !!L_PjYr4		VALUE NUMERIC 4
	END ITEMLIST
						NOSORT
	END PART
	EXPLAIN !!L_PjYearsExplain
	END POLICY
POLICY !!L_PjAddSpace
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Edit"
					VALUENAME SpaceBeforeTimeLabel
					VALUEON NUMERIC 1
					VALUEOFF NUMERIC 0 
	EXPLAIN !!L_PjAddSpaceExplain
	END POLICY
END CATEGORY
CATEGORY !!L_PjHyperLinkAppear
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Edit"
POLICY !!L_PjHyperLinkColour
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Edit"
	PART !!L_PjHyperLinkColour DROPDOWNLIST
	VALUENAME WebNotFollowedColor
	ITEMLIST
		NAME !!L_PjLink16		VALUE NUMERIC 16
		NAME !!L_PjLink0		VALUE NUMERIC 0
		NAME !!L_PjLink1		VALUE NUMERIC 1
		NAME !!L_PjLink2		VALUE NUMERIC 2
		NAME !!L_PjLink3		VALUE NUMERIC 3
		NAME !!L_PjLink4		VALUE NUMERIC 4
		NAME !!L_PjLink5		VALUE NUMERIC 5		DEFAULT
		NAME !!L_PjLink6		VALUE NUMERIC 6
		NAME !!L_PjLink7		VALUE NUMERIC 7
		NAME !!L_PjLink8		VALUE NUMERIC 8
		NAME !!L_PjLink9		VALUE NUMERIC 9
		NAME !!L_PjLink10		VALUE NUMERIC 10
		NAME !!L_PjLink11		VALUE NUMERIC 11
		NAME !!L_PjLink12		VALUE NUMERIC 12
		NAME !!L_PjLink13		VALUE NUMERIC 13
		NAME !!L_PjLink14		VALUE NUMERIC 14
		NAME !!L_PjLink15		VALUE NUMERIC 15
	END ITEMLIST
	NOSORT
	END PART
	EXPLAIN !!L_PjHyperLinkColourExplain
	END POLICY
POLICY !!L_PjFollowedlinkColour
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Edit"
	PART !!L_PjFollowedlinkColour DROPDOWNLIST
	VALUENAME WebFollowedColor
	ITEMLIST
		NAME !!L_PjLink16		VALUE NUMERIC 16
		NAME !!L_PjLink0		VALUE NUMERIC 0
		NAME !!L_PjLink1		VALUE NUMERIC 1
		NAME !!L_PjLink2		VALUE NUMERIC 2
		NAME !!L_PjLink3		VALUE NUMERIC 3
		NAME !!L_PjLink4		VALUE NUMERIC 4
		NAME !!L_PjLink5		VALUE NUMERIC 5
		NAME !!L_PjLink6		VALUE NUMERIC 6
		NAME !!L_PjLink7		VALUE NUMERIC 7
		NAME !!L_PjLink8		VALUE NUMERIC 8
		NAME !!L_PjLink9		VALUE NUMERIC 9
		NAME !!L_PjLink10		VALUE NUMERIC 10
		NAME !!L_PjLink11		VALUE NUMERIC 11
		NAME !!L_PjLink12		VALUE NUMERIC 12	DEFAULT
		NAME !!L_PjLink13		VALUE NUMERIC 13
		NAME !!L_PjLink14		VALUE NUMERIC 14
		NAME !!L_PjLink15		VALUE NUMERIC 15
	END ITEMLIST
	NOSORT
	END PART
	EXPLAIN !!L_PjFollowedlinkColourExplain
	END POLICY
POLICY !!L_PjUnderlineLinks
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Edit"
	VALUENAME WebUnderlineHyperlinks
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0	
	EXPLAIN !!L_PjUnderlineLinksExplain
	END POLICY
END CATEGORY
END CATEGORY
CATEGORY !!L_PjCalendar
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calendar"
POLICY !!L_PjWeekStarts
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calendar"
	PART !!L_PjWeekStarts DROPDOWNLIST
	VALUENAME "Start Week Day"
	ITEMLIST
		NAME !!L_PjWeek6		VALUE NUMERIC 6		DEFAULT
		NAME !!L_PjWeek0		VALUE NUMERIC 0
		NAME !!L_PjWeek1		VALUE NUMERIC 1
		NAME !!L_PjWeek2		VALUE NUMERIC 2
		NAME !!L_PjWeek3		VALUE NUMERIC 3
		NAME !!L_PjWeek4		VALUE NUMERIC 4
		NAME !!L_PjWeek5		VALUE NUMERIC 5
	END ITEMLIST
	NOSORT
	END PART
	EXPLAIN !!L_PjWeekStartsExplain
	END POLICY
POLICY !!L_PjFiscalYear
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calendar"
	PART !!L_PjFiscalYear DROPDOWNLIST
	VALUENAME "Fiscal Year Starts In"
	ITEMLIST
		NAME !!L_PjYear1		VALUE NUMERIC 1		DEFAULT
		NAME !!L_PjYear2		VALUE NUMERIC 2
		NAME !!L_PjYear3		VALUE NUMERIC 3
		NAME !!L_PjYear4		VALUE NUMERIC 4
		NAME !!L_PjYear5		VALUE NUMERIC 5
		NAME !!L_PjYear6		VALUE NUMERIC 6
		NAME !!L_PjYear7		VALUE NUMERIC 7
		NAME !!L_PjYear8		VALUE NUMERIC 8
		NAME !!L_PjYear9		VALUE NUMERIC 9
		NAME !!L_PjYear10		VALUE NUMERIC 10
		NAME !!L_PjYear11		VALUE NUMERIC 11
		NAME !!L_PjYear12		VALUE NUMERIC 12
	END ITEMLIST
	NOSORT
	END PART
	EXPLAIN !!L_PjFiscalYearExplain
	END POLICY
POLICY !!L_PjStartingYear
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calendar"
	VALUENAME "Use Starting Year for FY Numbering"
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjStartingYearExplain
	END POLICY
POLICY !!L_PjDefaultStartTime
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calendar"
	PART !!L_PjDefaultStartTime2 NUMERIC
	VALUENAME "Default Start Time"
	MAX 14400
	SPIN 0
	DEFAULT 4800
	END PART
	EXPLAIN !!L_PjDefaultStartTimeExplain
	END POLICY
POLICY !!L_PjDefaultEndTime
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calendar"
	PART !!L_PjDefaultEndTime2 NUMERIC
	VALUENAME "Default End Time"
	MAX 14400
	SPIN 0
	DEFAULT 10200
	END PART
	EXPLAIN !!L_PjDefaultEndTimeExplain
	END POLICY
POLICY !!L_PjHoursPerDay
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calendar"
	PART !!L_PjHoursPerDay EDITTEXT
	VALUENAME "Default Hours/Day"
	DEFAULT !!L_PjDefaultHoursPerDay
	END PART
	EXPLAIN !!L_PjHoursPerDayExplain
	END POLICY
POLICY !!L_PjHoursPerWeek
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calendar"
	PART !!L_PjHoursPerWeek EDITTEXT
	VALUENAME "Default Hours/Week"
	DEFAULT !!L_PjDefaultHoursPerWeek
	END PART
	EXPLAIN !!L_PjHoursPerWeekExplain
	END POLICY
POLICY !!L_PjDaysPerMonth
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calendar"
	PART !!L_PjDaysPerMonth NUMERIC
	VALUENAME "Default Days/Month"
	SPIN 1
	MIN 0
	MAX 100
	DEFAULT 20
	END PART
	EXPLAIN !!L_PjDaysPerMonthExplain
	END POLICY
END CATEGORY
CATEGORY !!L_PjSchedule
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Scheduling"
CATEGORY !!L_PjSchedProj
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Scheduling"
POLICY !!L_PjShowSchedMessage
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Scheduling"
	VALUENAME "Schedule Messages"
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjShowSchedMessageExplain
	END POLICY
POLICY !!L_PjAssignmentUnits
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Scheduling"
	PART !!L_PjAssignmentUnits DROPDOWNLIST
	VALUENAME "Show Assignment Units As a:"
	ITEMLIST
		NAME !!L_PjUnit0		VALUE NUMERIC 0		DEFAULT
		NAME !!L_PjUnit1		VALUE NUMERIC 1
	END ITEMLIST
	NOSORT
	END PART
	EXPLAIN !!L_PjAssignmentUnitsExplain
	END POLICY
END CATEGORY
CATEGORY !!L_PjSchedDoc
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Scheduling"
POLICY !!L_PjNewTasks
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Scheduling"
	PART !!L_PjNewTasks DROPDOWNLIST
	VALUENAME "New Tasks Start on Current Date"
	ITEMLIST
		NAME !!L_PjNewTask0	VALUE NUMERIC 0		DEFAULT
		NAME !!L_PjNewTask1	VALUE NUMERIC 1
	END ITEMLIST
	NOSORT
	END PART
	EXPLAIN !!L_PjNewTasksExplain
	END POLICY
POLICY !!L_PjDurationUnits
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Scheduling"
	PART !!L_PjDurationUnits DROPDOWNLIST
	VALUENAME "Default Duration Units"
	ITEMLIST
		NAME !!L_PjDur0		VALUE NUMERIC 3
		NAME !!L_PjDur1		VALUE NUMERIC 5
		NAME !!L_PjDur2		VALUE NUMERIC 7		DEFAULT
		NAME !!L_PjDur3		VALUE NUMERIC 9
		NAME !!L_PjDur4		VALUE NUMERIC 11
	END ITEMLIST
	NOSORT
	END PART
	EXPLAIN !!L_PjDurationUnitsExplain
	END POLICY
POLICY !!L_PjWorkUnits
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Scheduling"
	PART !!L_PjWorkUnits DROPDOWNLIST
	VALUENAME "Default Work Units"
	ITEMLIST
		NAME !!L_PjWorkUnits0	VALUE NUMERIC 3
		NAME !!L_PjWorkUnits1	VALUE NUMERIC 5		DEFAULT
		NAME !!L_PjWorkUnits2	VALUE NUMERIC 7
		NAME !!L_PjWorkUnits3	VALUE NUMERIC 9
		NAME !!L_PjWorkUnits4	VALUE NUMERIC 11
	END ITEMLIST
	NOSORT
	END PART
	EXPLAIN !!L_PjWorkUnitsExplain
	END POLICY
POLICY !!L_PjDefaultTaskTypes
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Scheduling"
	PART !!L_PjDefaultTaskTypes DROPDOWNLIST
	VALUENAME "Default Task Type"
	ITEMLIST
		NAME !!L_PjTaskType1	VALUE NUMERIC 1
		NAME !!L_PjTaskType0	VALUE NUMERIC 0		DEFAULT
		NAME !!L_PjTaskType2	VALUE NUMERIC 2
	END ITEMLIST
	NOSORT
	END PART
	EXPLAIN !!L_PjDefaultTaskTypesExplain
	END POLICY
POLICY !!L_PjNewTasksEffort
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Scheduling"
	VALUENAME "New Tasks Effort Driven"
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjNewTasksEffortExplain
	END POLICY
POLICY !!L_PjAutolinkTasks
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Scheduling"
	VALUENAME "Edit with Auto Link"
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjAutolinkTasksExplain
	END POLICY
POLICY !!L_PjSplitinProgressTasks
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Scheduling"
	VALUENAME "Auto Split Tasks"
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjSplitinProgressTasksExplain
	END POLICY
POLICY !!L_PjTasksHonorConstraints
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Scheduling"
	VALUENAME HonorConstraints
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjTasksHonorConstraintsExplain
	END POLICY
POLICY !!L_PjShowEstimatedDurations
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Scheduling"
	VALUENAME "Show Estimated Durations"
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjShowEstimatedDurationsExplain
	END POLICY
POLICY !!L_PjNewTasksEstDurations
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Scheduling"
	VALUENAME "New Tasks Have Estimated Durations"
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjNewTasksEstDurationsExplain
	END POLICY
END CATEGORY
END CATEGORY
CATEGORY !!L_PjCalculation
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calculation"
CATEGORY !!L_PjCalcProject
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calculation"
POLICY !!L_PjAutoCalc
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calculation"
	VALUENAME "Auto Calc"
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjAutoCalcExplain
	END POLICY
POLICY !!L_PjCalcAll
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calculation"
	VALUENAME CalcAll
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjCalcAllExplain
	END POLICY
END CATEGORY
CATEGORY !!L_PjCalcProjectFile
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calculation"
POLICY !!L_PjUpdatingTask
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calculation"
	VALUENAME "Auto Track Resources"
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjUpdatingTaskExplain
	END POLICY
POLICY !!L_PjMoveRemaining
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calculation"
	VALUENAME "MoveRemaining"
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjMoveRemainingExplain
	END POLICY
POLICY !!L_PjAndMoveCompleted
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calculation"
	VALUENAME "AndMoveCompleted"
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjAndMoveCompletedExplain
	END POLICY
POLICY !!L_PjMoveCompleted
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calculation"
	VALUENAME "MoveCompleted"
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjMoveCompletedExplain
	END POLICY
POLICY !!L_PjAndMoveRemaining
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calculation"
	VALUENAME "AndMoveRemaining"
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjAndMoveRemainingExplain
	END POLICY
POLICY !!L_PjEditstoTotalTask
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calculation"
	VALUENAME "Edits to total task %Complete will be spread to the status date"
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjEditstoTotalTaskExplain
	END POLICY
POLICY !!L_PjInsertedProjects
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calculation"
	VALUENAME "Inserted projects are calculated like summary tasks"
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjInsertedProjectsExplain
	END POLICY
POLICY !!L_PjActualCostsCalc
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calculation"
	VALUENAME "Actual costs are always calculated by Microsoft Office Project"
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjActualCostsCalcExplain
	END POLICY
POLICY !!L_PjEditToTotalSpread
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calculation"
	VALUENAME "Edits to total actual cost will be spread to the status date"
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjEditToTotalSpreadExplain
	END POLICY
POLICY !!L_PjDefaultFixedAccrual
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calculation"
	PART !!L_PjDefaultFixedAccrual DROPDOWNLIST
	VALUENAME "Default Fixed Costs Accrual"
	ITEMLIST
		NAME !!L_PjFixed0		VALUE NUMERIC 1
		NAME !!L_PjFixed1		VALUE NUMERIC 3		DEFAULT
		NAME !!L_PjFixed2		VALUE NUMERIC 2
	END ITEMLIST
	NOSORT
	END PART
	EXPLAIN !!L_PjDefaultFixedAccrualExplain
	END POLICY
POLICY !!L_PjCalcMultipleCriticalPaths
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calculation"
	VALUENAME "Calculate Multiple Critical Paths"
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjCalcMultipleCriticalPathsExplain
	END POLICY
POLICY !!L_PjCritIfLess
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calculation"
	PART !!L_PjCritIfLess NUMERIC
	VALUENAME "Show As Critical if Slack"
	SPIN 1
	MIN 0
	MAX 9999
	DEFAULT 0
	END PART
	EXPLAIN !!L_PjCritIfLessExplain
	END POLICY
CATEGORY !!L_PjEV
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calculation"
POLICY !!L_PjEVMethod
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calculation"
	PART !!L_PjEVMethod DROPDOWNLIST
	VALUENAME "EVMethod"
	ITEMLIST
		NAME !!L_PjEVMethod0	VALUE NUMERIC 0		DEFAULT
		NAME !!L_PjEVMethod1	VALUE NUMERIC 1
	END ITEMLIST
	NOSORT
	END PART
	EXPLAIN !!L_PjEVMethodExplain
	END POLICY
POLICY !!L_PjEVBaseline
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Calculation"
	PART !!L_PjEVBaseline DROPDOWNLIST
	VALUENAME "EVBaseline"
	ITEMLIST
		NAME !!L_PjEVBaseline0	VALUE NUMERIC 1		DEFAULT
		NAME !!L_PjEVBaseline1	VALUE NUMERIC 12
		NAME !!L_PjEVBaseline2	VALUE NUMERIC 13
		NAME !!L_PjEVBaseline3	VALUE NUMERIC 14
		NAME !!L_PjEVBaseline4	VALUE NUMERIC 15
		NAME !!L_PjEVBaseline5	VALUE NUMERIC 16
		NAME !!L_PjEVBaseline6	VALUE NUMERIC 17
		NAME !!L_PjEVBaseline7	VALUE NUMERIC 18
		NAME !!L_PjEVBaseline8	VALUE NUMERIC 19
		NAME !!L_PjEVBaseline9	VALUE NUMERIC 20
		NAME !!L_PjEVBaseline10	VALUE NUMERIC 21
	END ITEMLIST
	NOSORT
	END PART
	EXPLAIN !!L_PjEVBaselineExplain
	END POLICY
END CATEGORY
END CATEGORY
END CATEGORY
CATEGORY !!L_PjSave
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Save"
POLICY !!L_PjFileType
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Save"
	PART !!L_PjFileType DROPDOWNLIST
	VALUENAME DefaultSaveFormat
	ITEMLIST
		NAME !!L_PjType0		VALUE "MSProject.MPP.12" DEFAULT
		NAME !!L_PjType1		VALUE "MSProject.MPT.12"
		NAME !!L_PjType2		VALUE "MSProject.MPP.9"
	END ITEMLIST
	NOSORT
	END PART
	EXPLAIN !!L_PjFileTypeExplain
	END POLICY
CATEGORY !!L_PjFileLocations 
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Save"
POLICY !!L_PjFileLocProjects
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Save"
	PART !!L_PjFileLocProjects EDITTEXT
	VALUENAME DefaultProjectsPath
	EXPANDABLETEXT
	REQUIRED
	END PART
	EXPLAIN !!L_PjFileLocProjectsExplain
	END POLICY
POLICY !!L_PjFileLocUserTemplates
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Save"
	PART !!L_PjFileLocUserTemplates EDITTEXT
	VALUENAME DefaultUserTemplatesPath
	EXPANDABLETEXT
	END PART
	EXPLAIN !!L_PjFileLocUserTemplatesExplain
	END POLICY
END CATEGORY
CATEGORY !!L_PjAutoSave
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Save"
POLICY !!L_PjSaveEvery
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Save"
	VALUENAME AutomaticSave
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjSaveEveryExplain
	END POLICY
POLICY !!L_PjSaveInterval
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Save"
	PART !!L_PjSaveInterval NUMERIC
	VALUENAME AutomaticSaveInterval
	SPIN 1
	MIN 1
	MAX 120
	DEFAULT 10
	END PART
	EXPLAIN !!L_PjSaveIntervalExplain
	END POLICY
POLICY !!L_PjAutomaticSaveOption
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Save"
	VALUENAME AutomaticSaveOption
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 2
	EXPLAIN !!L_PjAutomaticSaveOptionExplain
	END POLICY
POLICY !!L_PjAutomaticSavePrompt
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Save"
	VALUENAME AutomaticSavePrompt
	VALUEON NUMERIC 1
	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjAutomaticSavePromptExplain
	END POLICY
END CATEGORY
END CATEGORY
CATEGORY !!L_PjInterface
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Interface"
POLICY !!L_DisableInternalIDMatching
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Interface"
   	VALUENAME "Disable Internal ID Matching"
   	VALUEON NUMERIC 1
   	VALUEOFF NUMERIC 0
	EXPLAIN !!L_DisableInternalIDMatchingExplain
	END POLICY
CATEGORY !!L_PjShowIndicators
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Interface"
POLICY !!L_PjResourceAssignOOUI
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Interface"
      	VALUENAME ResourceAssignOOUI
      	VALUEON NUMERIC 1
      	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjResourceAssignOOUIExplain
	END POLICY
POLICY !!L_PjChangeDurationOOUI
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Interface"
      	VALUENAME ChangeDurationOOUI
      	VALUEON NUMERIC 1
      	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjChangeDurationOOUIExplain
	END POLICY
POLICY !!L_PjEnterDateOOUI
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Interface"
      	VALUENAME EnterDateOOUI
      	VALUEON NUMERIC 1
      	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjEnterDateOOUIExplain
	END POLICY
POLICY !!L_PjDeleteNameOOUI
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Interface"
      	VALUENAME DeleteNameOOUI
      	VALUEON NUMERIC 1
      	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjDeleteNameOOUIExplain
	END POLICY
END CATEGORY
CATEGORY !!L_PjPGSettings
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Interface"
POLICY !!L_PjGBUIDisplayToggle
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Interface"
      	VALUENAME GBUIDisplayToggle
      	VALUEON NUMERIC 1
      	VALUEOFF NUMERIC 0
	EXPLAIN !!L_PjGBUIDisplayToggleExplain
	END POLICY
END CATEGORY
CATEGORY !!L_PjPGSettingsForProject1
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Interface"
POLICY !!L_PjUseDefaultStartPage
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Interface"
	PART !!L_PjUseDefaultStartPage DROPDOWNLIST
              VALUENAME UseDefaultStartPage
	ITEMLIST
                      NAME !!L_PjUseDefaultStartPage1		VALUE NUMERIC 1 DEFAULT
                      NAME !!L_PjUseDefaultStartPage2		VALUE NUMERIC 0 
	END ITEMLIST
              NOSORT
	END PART
	PART !!L_PjGBUIDefaultPageURL EDITTEXT
              VALUENAME GBUIDefaultStartPageURL
              DEFAULT !!L_PjGBUIDefaultPageURLString
	END PART
	EXPLAIN !!L_PjUseDefaultStartPageExplain
	END POLICY
POLICY !!L_PjUseDefaultXMLSchema
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Options\Interface"
	PART !!L_PjUseDefaultXMLSchema DROPDOWNLIST
              VALUENAME UseDefaultXMLSchema
	ITEMLIST
                      NAME !!L_PjUseDefaultXMLSchema1		VALUE NUMERIC 1 DEFAULT
                      NAME !!L_PjUseDefaultXMLSchema2		VALUE NUMERIC 0 
	END ITEMLIST
              NOSORT
	END PART
	PART !!L_PjGBUIXMLSchemaPath EDITTEXT
              VALUENAME GBUIXMLSchemaPath
              DEFAULT !!L_PjGBUIXMLSchemaPathString
	END PART
	EXPLAIN !!L_PjUseDefaultXMLSchemaExplain
	END POLICY
END CATEGORY
END CATEGORY
END CATEGORY
CATEGORY !!L_PjSecurity
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Security"
POLICY !!L_Legacyfileformats 
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Security"
	PART !!L_Empty DROPDOWNLIST
		VALUENAME LegacyFiles
	ITEMLIST
			NAME !!L_Donotopensave VALUE NUMERIC 0
		        NAME !!L_Promptwhenopeningsaving VALUE NUMERIC 1
		        NAME !!L_Allowopeningsaving VALUE NUMERIC 2
	END ITEMLIST
		NOSORT
	END PART
	EXPLAIN !!L_LegacyfileformatsExplain
	END POLICY
POLICY !!L_MacroTrustInstalled
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Security"
	VALUENAME DontTrustInstalledFiles
	VALUEON NUMERIC 0 ;reverse
	VALUEOFF NUMERIC 1
	EXPLAIN !!L_TrustInstalledAddinsandTemplatesExplain
	END POLICY
CATEGORY !!L_PJMacro
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Security"
POLICY !!L_PjSecurityLevel
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Security"
	PART !!L_PjSecurityLevel DROPDOWNLIST
              VALUENAME Level
	ITEMLIST
                      NAME !!L_PjSecurityLevel1		VALUE NUMERIC 1 
                      NAME !!L_PjSecurityLevel2		VALUE NUMERIC 2 
                      NAME !!L_PjSecurityLevel3		VALUE NUMERIC 3 DEFAULT
                      NAME !!L_PjSecurityLevel4		VALUE NUMERIC 4
	END ITEMLIST
              NOSORT
	END PART
	EXPLAIN !!L_PjSecurityLevelExplain
	END POLICY
END CATEGORY
END CATEGORY
CATEGORY !!L_PjCache
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Settings"
POLICY !!L_CacheLocation
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Settings"
	PART !!L_CacheLocation EDITTEXT
	 VALUENAME CacheLocation
	 EXPANDABLETEXT
	END PART
	EXPLAIN !!L_CacheLocationExplain
	END POLICY
POLICY !!L_CacheSizePerProfile
KEYNAME "Software\Microsoft\Office\12.0\MS Project\Settings"
	PART !!L_CacheSizePerProfile NUMERIC
         VALUENAME CacheSizePerProfile
	END PART
	EXPLAIN !!L_CacheSizePerProfileExplain
	END POLICY
END CATEGORY
CATEGORY !!L_Miscellaneous
KEYNAME Software\Microsoft\Office\12.0\Common\General
POLICY !!L_MRUTemplateListLength 
KEYNAME Software\Microsoft\Office\12.0\Common\General
	PART !!L_MRUTemplateListLength NUMERIC
				VALUENAME RecentTemplatesList 
				MIN 0
				MAX 9
	END PART
	EXPLAIN !!L_MRUTemplateListLengthExplain
	END POLICY
END CATEGORY
END CATEGORY


[Strings]
L_MacroTrustInstalled="Trust all installed add-ins and templates"
L_Empty=" "
L_Miscellaneous="Miscellaneous"
L_Security="Security"
L_Allowopeningsaving="Allow opening and saving"
L_Promptwhenopeningsaving="Prompt when opening and saving"
L_Donotopensave="Do not open or save"
L_LegacyfileformatsExplain="Allows you manage whether users can open or save files in Project with file formats from previous versions or file formats that are not default. By default, users can not open or save files with formats from previous versions."
L_Legacyfileformats="Previous-version file formats"
L_GregorianCalndar="Gregorian Calendar"
L_HirjriCalendar="Hijri Calendar"
L_ThaiBuddhist="Thai Buddhist"
L_ProjectSummaryTaskExplain="Allows you to manage whether the project summary task is displayed. If you enable this setting, the project summary task is displayed. If this setting is disabled or not configured, the user's default setting is used."
L_ProjectSummaryTask="Project Summary Task"
L_EnableuntrustedintranetzoneaccesstoProjectServerExplain="Allows users to access Project Server Web sites and Workspaces that have not been added to their trusted internet zones. If you enable this setting, users can access Project Server and Microsoft Windows SharePoint Services sites that are not in their trusted internet zones. If this setting is disabled or not configured, users are required to add the Project Server and Microsoft Windows SharePoint Services sites to their trusted internet site zones."
L_EnableuntrustedintranetzoneaccesstoProjectServer="Enable untrusted intranet zone access to Project server"
L_CalendarTypeExplain="Allows you to set the default calendar type. You need to have the Complex Script and East Asian language packs installed on the operating system in order for this setting to be available. If you enable this setting, you can set the default calendar type. If you disable or do not configure this setting, the user's default setting is used."
L_CalendarType="Calendar Type"
L_MRUTemplateListLength="Most Recently Used Template List Length"
L_MRUTemplateListLengthExplain="This setting determines the length of the recently used templates list in the New Document task pane (File New...). The maximum value is 9 and the minimum value is 0. This setting applies only applies to Project."
L_Proj="Microsoft Office Project 2007"
L_PjTools="Tools | Options..."
L_PjView="View"
L_PjDefaultView="Default View"
L_PjDefaultViewExplain="Specifies the view that Project displays at startup.\n\nIf you enable this setting, you can set the default view that is displayed at startup.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjView0="Bar Rollup"
L_PjView1="Calendar"
L_PjView2="Descriptive Network Diagram"
L_PjView3="Detail Gantt"
L_PjView4="Gantt Chart"
L_PjView5="Leveling Gantt"
L_PjView6="Milestone Date Rollup"
L_PjView7="Milestone Rollup"
L_PjView8="Network Diagram"
L_PjView9="Relationship Diagram"
L_PjView10="Resource Allocation"
L_PjView11="Resource Form"
L_PjView12="Resource Graph"
L_PjView13="Resource Names Form"
L_PjView14="Resource Sheet"
L_PjView15="Resource Usage"
L_PjView16="Task Details Form"
L_PjView17="Task Entry"
L_PjView18="Task Form"
L_PjView19="Task Name Form"
L_PjView20="Task Sheet"
L_PjView21="Task Usage"
L_PjView22="Tracking Gantt"
L_PjDateFormat="Date Format"
L_PjDateFormatExplain="Specifies the format for displaying dates.  Some information, such as time formats and the date separator, is set through the Control Panel.\n\nIf you enable this setting, dates are displayed in the format you set.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjDate0="1/31/00 12:33 PM"
L_PjDate1="1/31/00"
L_PjDate20="1/31/2000"
L_PjDate2="January 31, 2000 12:33 PM"
L_PjDate3="January 31, 2000"
L_PjDate4="Jan 31 12:33 PM"
L_PjDate5="Jan 31 '00"
L_PjDate6="January 31"
L_PjDate7="Jan 31"
L_PjDate8="Mon 1/31/00 12:33 PM"
L_PjDate9="Mon 1/31/00"
L_PjDate10="Mon Jan 31, '00"
L_PjDate11="Mon 12:33 PM"
L_PjDate15="Mon Jan 31"
L_PjDate16="Mon 1/31"
L_PjDate17="Mon 31"
L_PjDate12="1/31"
L_PjDate13="31"
L_PjDate14="12:33 PM"
L_PjDate18="W1/1"
L_PjDate19="W1/1/00 12:33 PM"
L_MultiCurrencyExplain="Allows you to manage whether users can set the default currency type for their new project plans. If you enable this setting, the default currency type is enforced for all new project plans. If this setting is disabled or not configured, users can set the default currency type for new project plans."
L_DefaultProjectCurrency="Default Project Currency"
L_UnitedArabEmiratesDirhams="United Arab Emirates, Dirhams"
L_AfghanistanAfghanis="Afghanistan, Afghanis"
L_AlbaniaLeke="Albania, Leke"
L_ArmeniaDrams="Armenia, Drams"
L_NetherlandsAntillesGuilders="Netherlands Antilles, Guilders (also called Florins)"
L_AngolaKwanza="Angola, Kwanza"
L_ArgentinaPesos="Argentina, Pesos"
L_AustraliaDollars="Australia, Dollars"
L_ArubaGuilders_alsocalledFlorins="Aruba, Guilders (also called Florins)"
L_AzerbaijanManats="Azerbaijan, Manats"
L_BosniaandHerzegovinaConvertibleMarka="Bosnia and Herzegovina, Convertible Marka"
L_BarbadosDollars="Barbados, Dollars"
L_BangladeshTaka="Bangladesh, Taka"
L_BulgariaLeva="Bulgaria, Leva"
L_BahrainDinars="Bahrain, Dinars"
L_BurundiFrancs="Burundi, Francs"
L_BermudaDollars="Bermuda, Dollars"
L_BruneiDarussalamDollars="Brunei Darussalam, Dollars"
L_BoliviaBolivianos="Bolivia, Bolivianos"
L_BrazilBrazilReal="Brazil, Brazil Real"
L_BahamasDollars="Bahamas, Dollars"
L_BhutanNgultrum="Bhutan, Ngultrum"
L_BotswanaPulas="Botswana, Pulas"
L_BelarusRubles="Belarus, Rubles"
L_BelizeDollars="Belize, Dollars"
L_CanadaDollars="Canada, Dollars"
L_CongoKinshasaCongoleseFrancs="Congo//Kinshasa, Congolese Francs"
L_SwitzerlandFrancs="Switzerland, Francs"
L_ChilePesos="Chile, Pesos"
L_ChinaYuanRenminbi="China, Yuan Renminbi"
L_ColombiaPesos="Colombia, Pesos"
L_CostaRicaColones="Costa Rica, Colones"
L_SerbiaDinars="Serbia, Dinars"
L_CubaPesos="Cuba, Pesos"
L_CapeVerdeEscudos="Cape Verde, Escudos"
L_CyprusPounds="Cyprus, Pounds"
L_CzechRepublicKoruny="Czech Republic, Koruny"
L_DjiboutiFrancs="Djibouti, Francs"
L_DenmarkKroner="Denmark, Kroner"
L_DominicanRepublicPesos="Dominican Republic, Pesos"
L_AlgeriaAlgeriaDinars="Algeria, Algeria Dinars"
L_EstoniaKrooni="Estonia, Krooni"
L_EgyptPounds="Egypt, Pounds"
L_EritreaNakfa="Eritrea, Nakfa"
L_EthiopiaBirr="Ethiopia, Birr"
L_EuroMemberCountriesEuro="Euro Member Countries, Euro"
L_FijiDollars="Fiji, Dollars"
L_FalklandIslands_Malvinas_Pounds="Falkland Islands (Malvinas), Pounds"
L_UnitedKingdomPounds="United Kingdom, Pounds"
L_GeorgiaLari="Georgia, Lari"
L_GuernseyPounds="Guernsey, Pounds"
L_GhanaCedis="Ghana, Cedis"
L_GibraltarPounds="Gibraltar, Pounds"
L_GambiaDalasi="Gambia, Dalasi"
L_GuineaFrancs="Guinea, Francs"
L_GuatemalaQuetzales="Guatemala, Quetzales"
L_GuyanaDollars="Guyana, Dollars"
L_HongKongDollars="Hong Kong, Dollars"
L_HondurasLempiras="Honduras, Lempiras"
L_CroatiaKuna="Croatia, Kuna"
L_HaitiGourdes="Haiti, Gourdes"
L_HungaryForint="Hungary, Forint"
L_IndonesiaRupiahs="Indonesia, Rupiahs"
L_IsraelNewShekels="Israel, New Shekels"
L_IsleofManPounds="Isle of Man, Pounds"
L_IndiaRupees="India, Rupees"
L_IraqDinars="Iraq, Dinars"
L_IranRials="Iran, Rials"
L_IcelandKronur="Iceland, Kronur"
L_JerseyPounds="Jersey, Pounds"
L_JamaicaDollars="Jamaica, Dollars"
L_JordanDinars="Jordan, Dinars"
L_JapanYen="Japan, Yen"
L_KenyaShillings="Kenya, Shillings"
L_KyrgyzstanSoms="Kyrgyzstan, Soms"
L_CambodiaRiels="Cambodia, Riels"
L_ComorosFrancs="Comoros, Francs"
L_Korea_North_Won="Korea (North), Won"
L_Korea_South_Won="Korea (South), Won"
L_KuwaitDinars="Kuwait, Dinars"
L_CaymanIslandsDollars="Cayman Islands, Dollars"
L_KazakhstanTenge="Kazakhstan, Tenge"
L_LaosKips="Laos, Kips"
L_LebanonPounds="Lebanon, Pounds"
L_SriLankaRupees="Sri Lanka, Rupees"
L_LiberiaDollars="Liberia, Dollars"
L_LesothoMaloti="Lesotho, Maloti"
L_LithuaniaLitai="Lithuania, Litai"
L_LatviaLati="Latvia, Lati"
L_LibyaDinars="Libya, Dinars"
L_MoroccoDirhams="Morocco, Dirhams"
L_MoldovaLei="Moldova, Lei"
L_MadagascarAriary="Madagascar, Ariary"
L_MacedoniaDenars="Macedonia, Denars"
L_Myanmar_Burma_Kyats="Myanmar (Burma), Kyats"
L_MongoliaTugriks="Mongolia, Tugriks"
L_MacauPatacas="Macau, Patacas"
L_MauritaniaOuguiyas="Mauritania, Ouguiyas"
L_MaltaLiri="Malta, Liri"
L_MauritiusRupees="Mauritius, Rupees"
L_Maldives_MaldiveIslands_Rufiyaa="Maldives (Maldive Islands), Rufiyaa"
L_MalawiKwachas="Malawi, Kwachas"
L_MexicoPesos="Mexico, Pesos"
L_MalaysiaRinggits="Malaysia, Ringgits"
L_MozambiqueMeticais="Mozambique, Meticais"
L_NamibiaDollars="Namibia, Dollars"
L_NigeriaNairas="Nigeria, Nairas"
L_NicaraguaCordobas="Nicaragua, Cordobas"
L_NorwayKrone="Norway, Krone"
L_NepalNepalRupees="Nepal, Nepal Rupees"
L_NewZealandDollars="New Zealand, Dollars"
L_OmanRials="Oman, Rials"
L_PanamaBalboa="Panama, Balboa"
L_PeruNuevosSoles="Peru, Nuevos Soles"
L_PapuaNewGuineaKina="Papua New Guinea, Kina"
L_PhilippinesPesos="Philippines, Pesos"
L_PakistanRupees="Pakistan, Rupees"
L_PolandZlotych="Poland, Zlotych"
L_ParaguayGuarani="Paraguay, Guarani"
L_QatarRials="Qatar, Rials"
L_RomaniaNewLei="Romania, New Lei"
L_RussiaRubles="Russia, Rubles"
L_RwandaRwandaFrancs="Rwanda, Rwanda Francs"
L_SaudiArabiaRiyals="Saudi Arabia, Riyals"
L_SolomonIslandsDollars="Solomon Islands, Dollars"
L_SeychellesRupees="Seychelles, Rupees"
L_SudanDinars="Sudan, Dinars"
L_SwedenKronor="Sweden, Kronor"
L_SingaporeDollars="Singapore, Dollars"
L_SaintHelenaPounds="Saint Helena, Pounds"
L_SloveniaTolars="Slovenia, Tolars"
L_SlovakiaKoruny="Slovakia, Koruny"
L_SierraLeoneLeones="Sierra Leone, Leones"
L_SomaliaShillings="Somalia, Shillings"
L_SeborgaLuigini="Seborga, Luigini"
L_SurinameDollars="Suriname, Dollars"
L_SaoTomeandPrincipeDobras="São Tome and Principe, Dobras"
L_ElSalvadorColones="El Salvador, Colones"
L_SyriaPounds="Syria, Pounds"
L_SwazilandEmalangeni="Swaziland, Emalangeni"
L_ThailandBaht="Thailand, Baht"
L_TajikistanSomoni="Tajikistan, Somoni"
L_TurkmenistanManats="Turkmenistan, Manats"
L_TunisiaDinars="Tunisia, Dinars"
L_TongaPaanga="Tonga, Pa'anga"
L_TurkeyLiras="Turkey, Liras"
L_TurkeyNewLira="Turkey, New Lira"
L_TrinidadandTobagoDollars="Trinidad and Tobago, Dollars"
L_TuvaluTuvaluDollars="Tuvalu, Tuvalu Dollars"
L_TaiwanNewDollars="Taiwan, New Dollars"
L_TanzaniaShillings="Tanzania, Shillings"
L_UkraineHryvnia="Ukraine, Hryvnia"
L_UgandaShillings="Uganda, Shillings"
L_UnitedStatesofAmericaDollars="United States of America, Dollars"
L_UruguayPesos="Uruguay, Pesos"
L_UzbekistanSums="Uzbekistan, Sums"
L_VenezuelaBolivares="Venezuela, Bolivares"
L_VietNamDong="Viet Nam, Dong"
L_VanuatuVatu="Vanuatu, Vatu"
L_SamoaTala="Samoa, Tala"
L_CommunauteFinanciereAfricaineBEACFrancs="Communauté Financière Africaine BEAC, Francs"
L_SilverOunces="Silver, Ounces"
L_GoldOunces="Gold, Ounces"
L_EastCaribbeanDollars="East Caribbean Dollars"
L_InternationalMonetaryFund_IMF_SpecialDrawingRights="International Monetary Fund (IMF) Special Drawing Rights"
L_CommunauteFinanciereAfricaineBCEAOFrancs="Communauté Financière Africaine BCEAO, Francs"
L_PalladiumOunces="Palladium Ounces"
L_ComptoirsFrancaisduPacifiqueFrancs="Comptoirs Français du Pacifique Francs"
L_PlatinumOunces="Platinum, Ounces"
L_YemenRials="Yemen, Rials"
L_SouthAfricaRand="South Africa, Rand"
L_ZambiaKwacha="Zambia, Kwacha"
L_ZimbabweZimbabweDollars="Zimbabwe, Zimbabwe Dollars"
L_PjShow="Show"
L_PjStatusBar="Status Bar"
L_PjStatusBarExplain="Displays the status bar, which shows information about the progress of certain operations in Project.\n\nIf you enable this setting, the option to display the status bar is selected.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjWindowsinStatusBar="Windows in Taskbar"
L_PjWindowsinStatusBarExplain="Specifies whether separate windows are opened and displayed as separate buttons on the Windows taskbar for every open project.\n\nIf you enable this setting, a new window is displayed in the taskbar for each open project.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjScrollBar="Scroll Bars"
L_PjScrollBarExplain="Displays scrollbars for views.\n\nIf you enable this setting, scrollbars are displayed in the views.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjEntryBar="Entry Bar"
L_PjEntryBarExplain="Displays the entry bar, in which you can enter or edit field information.\n\nIf you enable this setting, the entry bar is displayed.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjOLElinks="OLE Link Indicators"
L_PjOLElinksExplain="Displays the indicator for OLE linked objects in the lower-right corner of the cell that contains the link.\n\nIf you enable this setting, the indicator is displayed for OLE linked objects.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjProjectScreentips="Project Screentips"
L_PjProjectScreentipsExplain="Displays tips for Gantt bars and field headings, including dates for timescale units, and the full cell contents if a cell is too narrow to completely display the text in sheet and Network Diagram views.\n\nIf you enable this setting, tips are displayed fro Gantt bars and field headings.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjGeneral="General"
L_UndoLevels="Undo Levels"
L_UndoLevelsExplain="Limits the number of actions (1-99)  that a user can undo. If you enable this setting, you can set a limit on  the number of actions (1-99) a user is can undo.  If you disable this setting or do not configure it, the user's default setting is used."
L_PjGeneralProjOptions="General options for Microsoft Office Project"
L_PjOpenLast="Open last file on startup"
L_PjOpenLastExplain="Upon starting Project, automatically opens the last used project file.\n\nIf you enable this setting, the last file that the user had open automatically re-opens when they start Project.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjPromptForInfo="Prompt for project info for new projects"
L_PjPromptForInfoExplain="Opens the Project Information dialog box whenever the user creates a new project.\n\nIf you enable this setting, the Project Information dialog box is displayed whenever you create a new project.\n\nIf you disable or do not configure this setting, the users default setting is followed."
L_PjSetAutoFilter="Set AutoFilter on for new projects"
L_PjSetAutoFilterExplain="Turns on AutoFilter automatically when the user creates a new project.\n\nIf you enable this setting, AutoFilter is automatically turned on when users create a new project.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjRecentlyUsed="Recently used file list (MRU)"
L_PjRecentlyUsedExplain="Sets the number of recently opened project files that display in the list at the bottom of the File menu.\n\nIf you enable this setting, the number of files displayed at the bottom of the File menu corresponds to the number you set.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjMRUT="Number of entries: "
L_PjGeneralOptions="General options for 'Project1'"
L_PjAutoAddNew="Automatically add new resources and tasks"
L_PjAutoAddNewExplain="Automatically adds new resources to the resource pool and assigns them default values whenever a new resource name or new resource’s initials are added.\n\nIf you enable this setting, new resources and tasks are automatically inserted into the project.\n\nIf you disable this setting, users are alerted whenever a new resource or task is created when making a new assignment.\n\nIf you do not configure this setting, the user’s default setting is used."
L_PjDefaultStdRate="Default standard rate"
L_PjDefaultStdRateExplain="Specifies the standard pay rate for new resources.\n\nIf you enable this setting, all new resources will use the specified standard pay rate.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjDefStdRateNum="0.00/h"
L_PjDefaultOtime="Default overtime rate"
L_PjDefaultOtimeExplain="Specifies the overtime pay rate for new resources.\n\nIf you enable this setting, all new resources will use the specified overtime pay rate\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjDefOtRateNum="0.00/h"
L_PjEdit="Edit"
L_PjEditOptionsProj="Edit options for Microsoft Office Project"
L_PjAllowCellDragDrop="Allow cell drag and drop"
L_PjMoveAfterEnter="Move selection after enter"
L_PjAsktoUpdate="Ask to update automatic links"
L_PjEditDirectlyCell="Edit directly in cell"
L_PjAllowCellDragDropExplain="Allow fields in sheets to be moved using the mouse.\n\nIf you enable this setting, users can move rows and fields to new locations using the mouse.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjMoveAfterEnterExplain="Automatically selects the field below the current field after the user presses the ENTER key.\n\nIf you enable this setting, the field below the current field is selected after the user presses the ENTER key.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjAsktoUpdateExplain="Prompts the user to update linked objects whenever they open a file containing OLE links, if the source has changed.\n\nIf you enable this setting, users are prompted to update linked objects whose source has changed whenever they open a file containing OLE links.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjEditDirectlyCellExplain="Allows editing directly in the selected cell.\n\nIf you enable this setting, users can directly edit a cell’s value.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjViewOptions="View options for time units in 'Project1'"
L_PjMinutes="Minutes"
L_PjMinutesExplain="Sets the label for minutes.\n\nIf you enable this setting, minutes are displayed with the specified label.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjMin0="m"
L_PjMin1="min"
L_PjMin2="minute"
L_PjMin3=" "
L_PjMin4=" "
L_PjHours="Hours"
L_PjHoursExplain="Sets the label for hours.\n\nIf you enable this setting, hours are displayed with the specified label.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjHr0="h"
L_PjHr1="hr"
L_PjHr2="hour"
L_PjHr3=" "
L_PjHr4=" "
L_PjDays="Days"
L_PjDaysExplain="Sets the label for days.\n\nIf you enable this setting, days are displayed with the specified label.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjDay0="d"
L_PjDay1="dy"
L_PjDay2="day"
L_PjDay3=" "
L_PjDay4=" "
L_PjWeeks="Weeks"
L_PjWeeksExplain="Sets the label for weeks.\n\nIf you enable this setting, weeks are displayed with the specified label.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjWk0="w"
L_PjWk1="wk"
L_PjWk2="week"
L_PjWk3=" "
L_PjWk4=" "
L_PjMonths="Months"
L_PjMonthsExplain="Sets the label for months.\n\nIf you enable this setting, months are displayed with the specified label.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjM0="mo"
L_PjM1="mon"
L_PjM2="month"
L_PjM3=" "
L_PjM4=" "
L_PjYears="Years"
L_PjYearsExplain="Sets the label for years.\n\nIf you enable this setting, years are displayed with the specified label.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjYr0="y"
L_PjYr1="yr"
L_PjYr2="year"
L_PjYr3=" "
L_PjYr4=" "
L_PjAddSpace="Add space before label"
L_PjAddSpaceExplain="Adds a space between numbers and time unit labels.\n\nIf you enable this setting, a space is displayed between numbers and the time unit label.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjHyperLinkAppear="Hyperlink appearance in 'Project1'"
L_PjHyperLinkColour="Hyperlink color"
L_PjHyperLinkColourExplain="Specifies the color of hyperlinks that have not yet been followed.\n\nIf you enable this setting, hyperlinks that have not been followed are displayed in the color you specified.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjLink16="Automatic"
L_PjLink0="Black"
L_PjLink1="Red"
L_PjLink2="Yellow"
L_PjLink3="Lime"
L_PjLink4="Aqua"
L_PjLink5="Blue"
L_PjLink6="Fuchsia"
L_PjLink7="White"
L_PjLink8="Maroon"
L_PjLink9="Green"
L_PjLink10="Olive"
L_PjLink11="Navy"
L_PjLink12="Purple"
L_PjLink13="Teal"
L_PjLink14="Gray"
L_PjLink15="Silver"
L_PjFollowedlinkColour="Followed hyperlink color"
L_PjFollowedlinkColourExplain="Specifies the color of hyperlinks that have already been followed.\n\nIf you enable this setting, hyperlinks that have been followed are displayed in the color you specified.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjUnderlineLinks="Underline hyperlinks"
L_PjUnderlineLinksExplain="Shows hyperlinks with underlined text.\n\nIf you enable this setting, hyperlinks are underlined.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjCalendar="Calendar"
L_PjWeekStarts="Week starts on"
L_PjWeekStartsExplain="Specifies the day of the week on which you want the scheduling week to begin.\n\nIf you enable this setting, weeks will start on the day you specified.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjWeek0="Sunday"
L_PjWeek1="Monday"
L_PjWeek2="Tuesday"
L_PjWeek3="Wednesday"
L_PjWeek4="Thursday"
L_PjWeek5="Friday"
L_PjWeek6="Saturday"
L_PjFiscalYear="Fiscal year starts in"
L_PjFiscalYearExplain="Specifies the month that begins the fiscal year.\n\nIf you enable this setting, the fiscal year will start on the month you specified.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjYear1="January"
L_PjYear2="February"
L_PjYear3="March"
L_PjYear4="April"
L_PjYear5="May"
L_PjYear6="June"
L_PjYear7="July"
L_PjYear8="August"
L_PjYear9="September"
L_PjYear10="October"
L_PjYear11="November"
L_PjYear12="December"
L_PjStartingYear="Use starting year for FY numbering"
L_PjStartingYearExplain="Labels the fiscal year using the calendar year in which the fiscal year begins.\n\nIf you enable this setting, the label for the fiscal year is the calendar year in which the fiscal year begins.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjDefaultStartTime="Default start time"
L_PjDefaultStartTimeExplain="Specifies the start time that Project assigns to tasks by default when you enter a start date without specifying a time.\n\nIf you enable this setting, new tasks where the user does not enter a start time will use the start time that you specified.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjDefaultEndTime="Default end time"
L_PjDefaultEndTimeExplain="Specifies the finish time that Project assigns to tasks by default when you enter a finish date without specifying a time.\n\nIf you enable this setting, new tasks where the user does not enter an end time will have the end time that you specified.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjDefaultStartTime2="Default start time (Minutes after 12am * 10)"
L_PjDefaultEndTime2="Default end time (Minutes after 12am * 10)"
L_PjHoursPerDay="Hours per day"
L_PjHoursPerDayExplain="Defines the number of hours that you want Project to assign to a task when the user enters a duration of one day.\n\nIf you enable this setting, day-long tasks will be assigned the number of hours that you specified.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjDefaultHoursPerDay="8"
L_PjHoursPerWeek="Hours per week"
L_PjHoursPerWeekExplain="Specifies the number of hours that you want Project to assign to a task when the user enters a duration of one week.\n\nIf you enable this setting, week-long tasks will be assigned the number of hours that you specified.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjDefaultHoursPerWeek="40"
L_PjDaysPerMonth="Days per month"
L_PjDaysPerMonthExplain="Defines the number of days that you want Project to assign to a task when you enter a duration of a month.\n\nIf you enable this setting, month-long tasks will be assigned the number of days that you specified.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjSchedule="Schedule"
L_PjSchedProj="Schedule options for Microsoft Office Project"
L_PjShowSchedMessage="Show scheduling messages"
L_PjShowSchedMessageExplain="Displays messages about schedule inconsistencies, such as a successor task starting before the finish of the predecessor task.\n\nIf you enable this setting, users will be alerted about scheduling inconsistencies.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjAssignmentUnits="Show assignment units as"
L_PjAssignmentUnitsExplain="Shows resource assignments units as a decimal or percentage.\n\nIf you enable this setting, resource assignment units will be set to the option you choose from the list.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjUnit0="Percentage"
L_PjUnit1="Decimal"
L_PjSchedDoc="Scheduling options for 'Project1'"
L_PjNewTasks="New tasks"
L_PjNewTasksExplain="Specifies the default start date for new tasks as they are entered in the current project.  For projects scheduled from the start date, the options are “Start on Project Start Date” and “Start on Current Date.”  For projects scheduled from the finish date, the options are “Finish on Project Finish Date” and “Start on Current Date.”\n\nIf you enable this setting, new tasks will start on the date you specified.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjNewTask0="Start on Project Start Date"
L_PjNewTask1="Start on Current Date"
L_PjDurationUnits="Duration is entered in"
L_PjDurationUnitsExplain="Specifies the unit of time (minutes, hours, days, weeks, or months) used by default in the Duration field.\n\nIf you enable this setting, the unit you specify will be used if the user does not specify a unit of time when entering a duration.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjDur0="Minutes"
L_PjDur1="Hours"
L_PjDur2="Days"
L_PjDur3="Weeks"
L_PjDur4="Months"
L_PjWorkUnits="Work is entered in"
L_PjWorkUnitsExplain="Specifies the default unit of time (minutes, hours, days, weeks, or months) used in the Work field in the current project.\n\nIf you enable this setting, whenever Project displays work values, the unit you specified will be used.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjWorkUnits0="Minutes"
L_PjWorkUnits1="Hours"
L_PjWorkUnits2="Days"
L_PjWorkUnits3="Weeks"
L_PjWorkUnits4="Months"
L_PjDefaultTaskTypes="Default task type"
L_PjDefaultTaskTypesExplain="Specifies the default task type for new tasks.\n\nIf you enable this setting, new tasks will be set to the type that you specified.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjTaskType1="Fixed Duration"
L_PjTaskType0="Fixed Units"
L_PjTaskType2="Fixed Work"
L_PjNewTasksEffort="New tasks are effort driven"
L_PjNewTasksEffortExplain="Specifies that new tasks are scheduled such that the work on the task remains constant as you add or remove assignments.\n\nIf you enable this setting, new tasks will be effort-driven.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjAutolinkTasks="Autolink inserted or moved tasks"
L_PjAutolinkTasksExplain="Automatically links tasks when you cut, move, or insert them.\n\nIf you enable this setting, tasks will automatically be linked when you cut, move, or insert them.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjSplitinProgressTasks="Split in-progress tasks"
L_PjSplitinProgressTasksExplain="Allows rescheduling of remaining duration and work when a task slips or reports progress ahead of schedule.\n\nIf you enable this setting, the remaining duration and work will be rescheduled if a task slips or reports progress ahead of schedule.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjTasksHonorConstraints="Tasks will always honor their constraint dates"
L_PjTasksHonorConstraintsExplain="Specifies that Project schedules tasks according to their constraint dates.\n\nIf you enable this setting, task constraints will always be honored when tasks are scheduled.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjShowEstimatedDurations="Show that tasks have estimated durations"
L_PjShowEstimatedDurationsExplain="Displays a question mark (?) after the duration unit of any task with an estimated duration.\n\nIf you enable this setting, tasks with estimated durations have a question mark after their duration unit.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjNewTasksEstDurations="New tasks have estimated durations"
L_PjNewTasksEstDurationsExplain="Specifies that all new tasks have estimated durations.\n\nIf you enable this setting, all new tasks will require estimated durations.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjCalculation="Calculation"
L_PjCalcProject="Calculation options for Microsoft Office Project"
L_PjAutoCalc="Automatic Calculation"
L_PjAutoCalcExplain="Specifies that calculations should be done automatically as soon as a change is made.\n\nIf you enable this setting, calculations will be made after every change to the project.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjCalcAll="Calculate all open projects"
L_PjCalcAllExplain="Specifies that Project should recalculate all open projects.\n\nIf you enable this setting, all open projects will be recalculated anytime Project does a calculation.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjCalcProjectFile="Calculation options for 'Project1'"
L_PjUpdatingTask="Updating task status updates resource status"
L_PjUpdatingTaskExplain="Automatically updates resource status, such as actual and remaining work and cost, whenever you update task status, such as percent complete, actual duration, or remaining duration.\n\nIf you enable this setting, task status updates are automatically applied to resources.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjEditstoTotalTask="Edits to total task % complete will be spread to the status date"
L_PjEditstoTotalTaskExplain="Distributes the changes to total percent complete evenly across the schedule to the project status date (or to the current date if you haven’t specified a project status date).\n\nIf you enable this setting, edits to total task percent complete are evenly distributed across the schedule up to the status date.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjInsertedProjects="Inserted projects are calculated like summary tasks"
L_PjInsertedProjectsExplain="Specifies that a single critical path is calculated throughout the master project, by treating inserted projects as summary tasks in the master project.\n\nIf you enable this setting, the critical path is calculated by treating inserted projects as summary tasks.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjActualCostsCalc="Actual costs are always calculated by Microsoft Office Project"
L_PjActualCostsCalcExplain="Specifies that Project calculates actual costs automatically, based upon resource rates, per-use resource costs, and fixed task costs.\n\nIf you enable this setting, Project will automatically calculate actual costs.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjEditToTotalSpread="Edits to total actual cost will be spread to the status date"
L_PjEditToTotalSpreadExplain="Distributes the changes to total actual cost evenly across the schedule to the status date (or to the current date if you have not specified a project status date).\n\nIf you enable this setting, Project will distribute edits to actual cost evenly across a task up to the status date.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjDefaultFixedAccrual="Default fixed costs accrual"
L_PjDefaultFixedAccrualExplain="Specifies how Project sets the fixed cost accrual for new tasks.\n\nIf you enable this setting, new tasks will accrue fixed cost according to the specification you made.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjFixed0="Start"
L_PjFixed1="Prorated"
L_PjFixed2="End"
L_PjCalcMultipleCriticalPaths="Calculate multiple critical paths"
L_PjCalcMultipleCriticalPathsExplain="Specifies that Project should calculate and display a critical path for each independent network of tasks within the project.\n\nIf you enable this setting, Project will calculate multiple critical paths.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjCritIfLess="Tasks are critical if slack is less than or equal to"
L_PjCritIfLessExplain="Specifies the number of days of slack Project uses to determine critical tasks.\n\nIf you enable this setting, tasks are marked as critical if the slack is less than or equal to the value you specified.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjMoveCompleted="Move end of completed parts after status date back to status date"
L_PjMoveCompletedExplain="Moves the completed portion of a task back to finish at the status date.\n\nIf you enable this setting, the completed portion of the task moves back to finish at the status date.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjAndMoveRemaining="And move start of remaining parts back to status date"
L_PjAndMoveRemainingExplain="Moves the remaining portion of a task back to start at the status date.\n\nIf you enable this setting, the remaining portion of the task moves back to start at the status date.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjMoveRemaining="Move start of remaining parts before status date forward to status date"
L_PjMoveRemainingExplain="Moves remaining portions of a task forward to start at the status date.\n\nIf you enable this setting, the remaining portion of the task moves forward to start at the status date.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjAndMoveCompleted="And move end of completed parts forward to status date"
L_PjAndMoveCompletedExplain="Moves the completed portion of a task forward to finish at the status date.\n\nIf you enable this setting, the completed portion of the task moves forward to finish at the status date.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjEV="Earned Value options for Project1"
L_PjEVMethod="Default task Earned Value method"
L_PjEVMethodExplain="Specifies the method used for earned value analysis.\n\nIf you enable this setting, Project will calculate earned value using the method you specified.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjEVMethod0="% Complete"
L_PjEVMethod1="Physical % Complete"
L_PjEVBaseline="Baseline for Earned Value calculations"
L_PjEVBaselineExplain="Specifies the baseline that is used to measure project performance using earned value analysis.\n\nIf you enable this setting, Project will calculate earned value using the baseline you specified.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjEVBaseline0="Baseline"
L_PjEVBaseline1="Baseline 1"
L_PjEVBaseline2="Baseline 2"
L_PjEVBaseline3="Baseline 3"
L_PjEVBaseline4="Baseline 4"
L_PjEVBaseline5="Baseline 5"
L_PjEVBaseline6="Baseline 6"
L_PjEVBaseline7="Baseline 7"
L_PjEVBaseline8="Baseline 8"
L_PjEVBaseline9="Baseline 9"
L_PjEVBaseline10="Baseline 10"
L_PjSave="Save"
L_PjFileType="Save Microsoft Office Project files as"
L_PjFileTypeExplain="Specifies the default file format that should be applied when any Project file is saved.\n\nIf you enable this setting, project files will be saved with the format you specified.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjType0="Project (*.mpp)"
L_PjType1="Template (*.mpt)"
L_PjType2="Project 2000-2003 (*.mpp)"
L_PjFileLocations="File locations"
L_PjFileLocProjects="Projects"
L_PjFileLocProjectsExplain="Specifies the default location in the computer system for saving and opening projects.\n\nIf you enable this policy setting, the location first appears in the Open and Save As dialog box.\n\nIf you disable or do not configure this policy setting, the users default for this setting is followed."
L_PjFileLocUserTemplates="User Templates"
L_PjFileLocUserTemplatesExplain="Specifies the default location in the computer system for saving and opening workgroup templates.\n\nIf you enable this policy setting, the location first appears in the Open and Save As dialog box.\n\nIf you disable or do not configure this policy setting, the users default for this setting is followed."
L_PjAutoSave="Auto Save Options"
L_PjSaveEvery="Auto Save every"
L_PjSaveEveryExplain="Specifies that you want Project to automatically save your projects periodically.\n\nIf you enable this setting, Project will save users projects at the specified interval.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjSaveInterval="Save Interval"
L_PjSaveIntervalExplain="Specifies how often Project should automatically save your projects.  This setting is only used by Project if Auto Save has been turned on.\n\nIf you enable this setting, Project will save users projects at the specified interval.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjAutomaticSaveOption="Save Active Project only"
L_PjAutomaticSaveOptionExplain="Saves only the active project at the interval you specify.  This setting is only used by Project if Auto Save is turned on.\n\nIf you enable this setting, Project will only save the active project at specified intervals.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjAutomaticSavePrompt="Prompt before saving"
L_PjAutomaticSavePromptExplain="Specifies whether Project should prompt the user before saving their project as a result of the Auto Save function.\n\nIf you enable this setting, users will be prompted before their project is automatically saved.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjInterface="Interface"
L_PjShowIndicators="Show indicators and Option butons for"
L_PjResourceAssignOOUI="Resource Assigments"
L_PjResourceAssignOOUIExplain="Specifies that the feedback triangle should appear in a corner of a field if the user assigns additional resources to a task that already has resources assigned.\n\nIf you enable this setting, a feedback triangle is displayed in the corner of a field if users assign additional resources to a task that already has resources assigned.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjChangeDurationOOUI="Edits to work, units or duration"
L_PjChangeDurationOOUIExplain="Specifies that the feedback triangle should appear in a corner of a Task Name field if you change the task’s start date or finish date.\n\nIf you enable this setting, a feedback triangle is displayed in the corner of the Task Name field if the user changes the task’s start or finish date.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjEnterDateOOUI="Edits to start and finish dates"
L_PjEnterDateOOUIExplain="Specifies that the feedback triangle should appear in a corner of the Duration field or the Task Name field if you change a task’s work, units, or duration.\n\nIf you enable this setting, a feedback triangle is displayed in the corner of the Duration or Task Name field if the user changes the task’s work, units, or duration.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjDeleteNameOOUI="Deletions in the Name column"
L_PjDeleteNameOOUIExplain="Specifies that the delete indicator should appear in the Indicators field if you delete text in the Task Name or Resource Names field.\n\nIf you enable this setting, the delete indicator will appear if the user deletes a Task Name or Resource Names.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjPGSettings="Project Guide settings"
L_PjGBUIDisplayToggle="Display Project Guide"
L_PjGBUIDisplayToggleExplain="Displays the side pane containing the Project Guide.\n\nIf you enable this setting, the Project Guide will be displayed.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjPGSettingsForProject1="Project Guide settings for 'Project1'"
L_PjUseDefaultStartPage="Project Guide Functionality and Layout page"
L_PjUseDefaultStartPageExplain="Choose whether the side pane displays the default Project Guide or a custom Project Guide your organization has developed.\n\nIf you enable this setting, the Project Guide you specified will be displayed when the Project Guide is opened.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjUseDefaultStartPage1="Use Microsoft Office Project's Default page"
L_PjUseDefaultStartPage2="Use a custom page"
L_PjGBUIDefaultPageURL="URL: "
L_PjGBUIDefaultPageURLString="gbui://mainpage.htm"
L_PjUseDefaultXMLSchema="Project Guide Content"
L_PjUseDefaultXMLSchemaExplain="Specifies whether the side pane displays the Project Guide content that comes with Project or custom content that your organization has developed.\n\nIf you enable this setting, content for the Project Guide is loaded from the specified location.\n\nIf you disable or do not configure this setting, the user’s default setting is used."
L_PjUseDefaultXMLSchema1="Use Microsoft Office Project's default content"
L_PjUseDefaultXMLSchema2="Use custom content"
L_PjGBUIXMLSchemaPath="XML file for custom content:"
L_PjGBUIXMLSchemaPathString="gbiu://gbui.xml"
L_DisableInternalIDMatching="Disable Internal ID Matching"
L_DisableInternalIDMatchingExplain="Prevent internal id matching. If you enable this setting, Project will not use internal identifiers to match different-language or renamed Organizer items between projects. If this setting is disabled or not configured, internal identifiers will be used to match different-language or renamed Organizer items between projects."
L_PJMacro="Tools | Macro"
L_TrustInstalledAddinsandTemplatesExplain="Specifies whether installed add-in and templates are trusted.\n\nIf you enable this policy setting, installed add-ins and templates are considered trusted and users will not be warned when they use them.\n\nIf you disable this policy setting, installed add-ins and templates are not considered trusted and users may not be able to use them depending on their security level.\n\nIf you do not configure this policy setting, the users default for this setting is followed."
L_PjSecurity="Security"
L_PjSecurityLevel="Security Level"
L_PjSecurityLevelExplain="Specifies the level of security used when opening documents.\n\nIf you enable this policy setting, the security level you specified will be used when user open documents.\n\nIf you disable or do not configure this policy setting, the users default for this setting is followed."
L_PjSecurityLevel1="Low (not recommended)"
L_PjSecurityLevel2="Medium"
L_PjSecurityLevel3="High"
L_PjSecurityLevel4="Very High"
L_PjCache="Tools | Local Project Cache"
L_CacheLocation="Local Project Cache Location"
L_CacheLocationExplain="Sets the location path of the local project cache on the user's computer."
L_CacheSizePerProfile="Local Project Cache Size Limit in MB"
L_CacheSizePerProfileExplain="Sets the size limit in MB of the local project cache.  This is applied per user profile. If this setting is enabled, the size of the cache will be set to the number specified. If this setting is disabled or not configured, users are able to set the cache size limit."


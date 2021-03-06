;// _lcid="1033" _version="12.0.4518"
CLASS MACHINE

CATEGORY !!L_CalendarPrintingAssistantMachine 
POLICY !!L_TemplatesdirectoryPolicy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
	PART !!L_Empty EDITTEXT
				VALUENAME TemplateDir
	END PART
	EXPLAIN !!L_TempatesdirecotryExplain 
	END POLICY
POLICY !!L_CalendardesigndirectoryPolicy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
	PART !!L_Empty EDITTEXT
				VALUENAME CalDesignDir
	END PART
	EXPLAIN !!L_CalendardesigndirectoryExplain 
	END POLICY
END CATEGORY
CLASS USER

CATEGORY !!L_CalendarPrintingAssistant 
POLICY !!L_FirstWeekPolicy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
	PART !!L_Empty DROPDOWNLIST
				VALUENAME firstWeekOfYearSelection
	ITEMLIST
					NAME !!L_Firstfullweek  VALUE "FirstFullWeek"
					NAME !!L_Firstfourdayweek  VALUE "FirstFourDayWeek"
					NAME !!L_Firstday  VALUE "FirstDay" DEFAULT
	END ITEMLIST
				NOSORT
	END PART
	EXPLAIN !!L_FirstWeekExplain 
	END POLICY
POLICY !!L_FirstdayofweekPolicy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
	PART !!L_Empty DROPDOWNLIST
				VALUENAME firstDayOfWeekSelection
	ITEMLIST
					NAME !!L_Sunday VALUE "sun" DEFAULT
					NAME !!L_Monday VALUE "mon"
					NAME !!L_Tuesday VALUE "tue"
					NAME !!L_Wednesday VALUE "wed"
					NAME !!L_Thursday VALUE "thu"
					NAME !!L_Friday VALUE "fri"
					NAME !!L_Saturday VALUE "sat"
	END ITEMLIST
				NOSORT
	END PART
	EXPLAIN !!L_FirstdayofweekExplain
	END POLICY
POLICY !!L_ShowweeknumbersPolicy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
			VALUENAME showWeekNumber
			VALUEON !!L_true
			VALUEOFF !!L_false
	EXPLAIN !!L_ShowweeknumbersExplain
	END POLICY
POLICY !!L_MinfontsizePolicy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
	PART !!L_Empty NUMERIC
				VALUENAME minSize
				MIN 1
				MAX 71
	END PART
	EXPLAIN !!L_MinfontsizeExplain 
	END POLICY
POLICY !!L_MincharspacingPolicy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
	PART !!L_Empty DROPDOWNLIST
				VALUENAME condense
	ITEMLIST
					NAME !!L_Condensed  VALUE "Condensed" DEFAULT
					NAME !!L_SemiCondensed  VALUE "SemiCondensed"
					NAME !!L_ExtraCondensed  VALUE "ExtraCondensed"
					NAME !!L_UltraCondensed  VALUE "UltraCondensed"
					NAME !!L_Normal  VALUE "Normal"
	END ITEMLIST
				NOSORT
	END PART
	EXPLAIN !!L_MincharspacingExplain 
	END POLICY
POLICY !!L_MinfontweightPolicy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
	PART !!L_Empty DROPDOWNLIST
				VALUENAME weight
	ITEMLIST
					NAME !!L_Thin VALUE "Thin" DEFAULT
					NAME !!L_Light VALUE "Light"
					NAME !!L_ExtraLight VALUE "ExtraLight"
					NAME !!L_Normal VALUE "Normal"
	END ITEMLIST
				NOSORT
	END PART
	EXPLAIN !!L_MinfontweightExplain 
	END POLICY
POLICY !!L_DropendtimesPolicy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
			VALUENAME adaptChecked
			VALUEON !!L_true
			VALUEOFF !!L_false
	EXPLAIN !!L_DropendtimesExplain 
	END POLICY
POLICY !!L_BreaklinesPolicy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
			VALUENAME break
			VALUEON !!L_true
			VALUEOFF !!L_false
	EXPLAIN !!L_BreaklinesExplain 
	END POLICY
POLICY !!L_ConsistencyPolicy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
			VALUENAME consistency
			VALUEON !!L_true
			VALUEOFF !!L_false
	EXPLAIN !!L_ConsistencyExplain 
	END POLICY
POLICY !!L_DefaultcolorschemePolicy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
	PART !!L_Empty EDITTEXT
				VALUENAME styleColors
	END PART
	EXPLAIN !!L_DefaultcolorschemeExplain 
	END POLICY
POLICY !!L_DefaultfontPolicy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
	PART !!L_Empty EDITTEXT
				VALUENAME styleFonts
	END PART
	EXPLAIN !!L_DefaultfontExplain 
	END POLICY
POLICY !!L_DefaultcalendardesignPolicy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
	PART !!L_Empty EDITTEXT
				VALUENAME styleCalendarDesigns
	END PART
	EXPLAIN !!L_DefaultcalendardesignExplain 
	END POLICY
POLICY !!L_SortbyduedatePolicy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
			VALUENAME tasksByDueDate
			VALUEON !!L_true
			VALUEOFF !!L_false
	EXPLAIN !!L_SortbyduedateExplain 
	END POLICY
POLICY !!L_SortbystartdatePolicy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
			VALUENAME tasksByStartDate
			VALUEON !!L_true
			VALUEOFF !!L_false
	EXPLAIN !!L_SortbystartdateExplain 
	END POLICY
POLICY !!L_ShowcompletedtasksPolicy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
			VALUENAME tasksShowCompleted
			VALUEON !!L_true
			VALUEOFF !!L_false
	EXPLAIN !!L_ShowcompletedtasksExplain 
	END POLICY
POLICY !!L_ShowundatedtasksPolicy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
			VALUENAME tasksShowUndated
			VALUEON !!L_true
			VALUEOFF !!L_false
	EXPLAIN !!L_ShowundatedtasksExplain 
	END POLICY
POLICY !!L_ShowMRUlistPolicy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
			VALUENAME showMRUList
			VALUEON !!L_true
			VALUEOFF !!L_false
	EXPLAIN !!L_ShowMRUlistExplain 
	END POLICY
POLICY !!L_MRU1Policy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
	PART !!L_Empty EDITTEXT
				VALUENAME MRU1
	END PART
	EXPLAIN !!L_MRU1Explain 
	END POLICY
POLICY !!L_MRU2Policy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
	PART !!L_Empty EDITTEXT
				VALUENAME MRU2
	END PART
	EXPLAIN !!L_MRU2Explain 
	END POLICY
POLICY !!L_MRU3Policy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
	PART !!L_Empty EDITTEXT
				VALUENAME MRU3
	END PART
	EXPLAIN !!L_MRU3Explain 
	END POLICY
POLICY !!L_MRU4Policy 
KEYNAME Software\Microsoft\Office\12.0\CPAO\Settings
	PART !!L_Empty EDITTEXT
				VALUENAME MRU4
	END PART
	EXPLAIN !!L_MRU4Explain 
	END POLICY
END CATEGORY


[Strings]
L_Empty=" "
L_CalendarPrintingAssistant="Microsoft Office Outlook 2007 日历打印助手"
L_CalendarPrintingAssistantMachine="Microsoft Office Outlook 2007 日历打印助手(计算机)"
L_FirstWeekPolicy="如何计算一年的第一周"
L_FirstWeekExplain="这将会影响包含周数的模板中的周数计算，以及日期选取器中周数的显示。"
L_Firstfullweek="第一个全周"
L_Firstfourdayweek="第一个满四天的周"
L_Firstday="第一天"
L_FirstdayofweekPolicy="如何计算一周的第一天"
L_FirstdayofweekExplain="在显示星期的模板以及日期选取器中，这将会切换显示以便首先显示指定的日期。在显式设置“每周第一天”属性的模板中，此设置不起作用。"
L_Sunday="星期日"
L_Monday="星期一"
L_Tuesday="星期二"
L_Wednesday="星期三"
L_Thursday="星期四"
L_Friday="星期五"
L_Saturday="星期六"
L_ShowweeknumbersPolicy="在日期选择区和日历视图中显示周数"
L_ShowweeknumbersExplain="选择此选项后，周数将显示在日期选取器以及支持使用“在日期选择区和日历视图中显示周数”条件来显示周数的模板中。"
L_true="true"
L_false="false"
L_MinfontsizePolicy="包含“紧凑列表”控件的模板所使用的最小字号"
L_MinfontsizeExplain="尝试缩小内容以适应“紧凑列表”控件时，日历打印助手将从模板中的指定字号开始尝试，根据需要缩小内容，直至达到此字符串中指定的值为止。在此之后，文本将不会进一步缩小(但会应用替代的大小调整策略，如丢弃结束时间)。如果此字符串中的值大于模板中指定的字号，则使用模板的值，而不执行任何缩小操作。"
L_MincharspacingPolicy="最小字符间距"
L_MincharspacingExplain="从视觉效果来看，此选项的作用是将文本沿水平方向压缩，这样将可以容纳更多内容。"
L_Condensed="紧缩"
L_SemiCondensed="半紧缩"
L_ExtraCondensed="超紧缩"
L_UltraCondensed="极紧缩"
L_Normal="普通"
L_MinfontweightPolicy="最小字体粗细"
L_MinfontweightExplain="从视觉效果来看，此选项的作用是使每个字符的实际形状“变细”，这样将可以容纳更多内容。"
L_Thin="纤细"
L_Light="细"
L_ExtraLight="特细"
L_DropendtimesPolicy="丢弃结束时间以显示更长的主题文本"
L_DropendtimesExplain="如果启用，则没有足够空间完全显示文本时，仅显示每个约会的开始时间。仅适用于基于“紧凑列表”的控件。"
L_BreaklinesPolicy="允许以字符为单位换行"
L_BreaklinesExplain="如果启用，则可能会从单词中间换行，以便每行可以最大限度地利用空间，而不是从单词结尾处换行。仅适用于基于“紧凑列表”的控件。"
L_ConsistencyPolicy="以统一的设置显示所有日期"
L_ConsistencyExplain="如果启用，模板中基于“紧凑列表”的控件都将共享网格中限制最严格的单元格的内容适应设置。例如，如果日历网格中的某个单元格尽可能缩小字体并丢弃结束时间，则启用“以统一设置显示所有日期”时，所有单元格都会共享这些设置。"
L_DefaultcolorschemePolicy="设置默认配色方案"
L_DefaultcolorschemeExplain="设置该值后，用户仍可更改当前配色方案，但无法将其他方案设置为默认方案。"
L_DefaultfontPolicy="设置默认字体方案"
L_DefaultfontExplain="设置该值后，用户仍可更改当前字体方案，但无法将其他方案设置为默认方案。"
L_DefaultcalendardesignPolicy="设置默认日历设计方案"
L_DefaultcalendardesignExplain="设置该值后，用户仍可更改当前日历设计方案，但无法将其他方案设置为默认方案。"
L_SortbyduedatePolicy="按截止日期对任务排序"
L_SortbyduedateExplain="设置该值后，将启用并灰显“视图”菜单下的“按截止日期显示任务”选项，以防用户修改此设置。“按截止日期显示任务”设置与“按开始日期显示任务”设置不能同时启用。"
L_SortbystartdatePolicy="按开始日期对任务排序"
L_SortbystartdateExplain="设置该值后，将启用并灰显“视图”菜单下的“按开始日期显示任务”选项，以防用户修改此设置。“按开始日期显示任务”设置与“按截止日期显示任务”设置不能同时启用。"
L_ShowcompletedtasksPolicy="显示完成的任务"
L_ShowcompletedtasksExplain="设置该值后，将启用并灰显“视图”菜单下的“显示完成的任务”选项，以防用户修改此设置。"
L_ShowundatedtasksPolicy="显示不带日期的任务"
L_ShowundatedtasksExplain="设置该值后，将启用并灰显“视图”菜单下的“显示不带日期的任务”选项，以防用户修改此设置。"
L_ShowMRUlistPolicy="在“文件”菜单下显示最近使用的文件"
L_ShowMRUlistExplain="“文件”菜单中将列出日历打印助手中最近打开的 4 个文件；如果启用此设置，则不会显示任何最近使用的文件。"
L_MRU1Policy="最近使用的文件条目 #1"
L_MRU2Policy="最近使用的文件条目 #2"
L_MRU3Policy="最近使用的文件条目 #3"
L_MRU4Policy="最近使用的文件条目 #4"
L_MRU1Explain="指定要在最近使用的文件条目 #1 中使用的文件。"
L_MRU2Explain="指定要在最近使用的文件条目 #2 中使用的文件。"
L_MRU3Explain="指定要在最近使用的文件条目 #3 中使用的文件。"
L_MRU4Explain="指定要在最近使用的文件条目 #4 中使用的文件。"
L_TemplatesdirectoryPolicy="存放所有模板的目录"
L_TempatesdirecotryExplain="所有保存在此目录中的用户创建或下载的模板都将在模板库中显示。"
L_CalendardesigndirectoryPolicy="存放所有日历设计方案的目录"
L_CalendardesigndirectoryExplain="所有保存在此目录中的用户创建或下载的日历设计方案都在日历样式方案库中显示。"


;// _lcid="1033" _version="12.0.4518"
CLASS USER

CATEGORY !!L_MicrosoftOfficeSharePointDesigner12
KEYNAME Software\Microsoft\Office\12.0
CATEGORY !!L_DefaultAuthoringOptions 
KEYNAME Software\Microsoft\Office\12.0
POLICY !!L_DefaultCSSSchema 
KEYNAME "Software\Microsoft\Office\12.0\SharePoint Designer\Restrictions"
	PART !!L_Empty DROPDOWNLIST
				VALUENAME CSSSchemaPath
	ITEMLIST
					NAME !!L_CSS1 VALUE "CSS10.XML"
					NAME !!L_CSS2 VALUE "CSS20.XML"
					NAME !!L_CSS21 VALUE "CSS21.XML"
					NAME !!L_CSSIE6 VALUE "CSS-IE60.XML" DEFAULT
	END ITEMLIST
				NOSORT
	END PART
	EXPLAIN !!L_DefaultCSSSchemaExplain
	END POLICY
POLICY !!L_DefaultDoctype
KEYNAME "Software\Microsoft\Office\12.0\SharePoint Designer\Restrictions"
	PART !!L_Empty DROPDOWNLIST
				VALUENAME DefaultDoctype
	ITEMLIST
					NAME !!L_None VALUE ""
					NAME !!L_HTML401Frameset VALUE "-//W3C//DTD HTML 4.01 Frameset//EN"
					NAME !!L_HTML401Transitional VALUE "-//W3C//DTD HTML 4.01 Transitional//EN"
					NAME !!L_HTML401Strict VALUE "-//W3C//DTD HTML 4.01//EN"
					NAME !!L_XHTML10Frameset VALUE "-//W3C//DTD XHTML 1.0 Frameset//EN"
					NAME !!L_XHTML10Transitional VALUE "-//W3C//DTD XHTML 1.0 Transitional//EN" DEFAULT
					NAME !!L_XHTML10Strict VALUE "-//W3C//DTD XHTML 1.0 Strict//EN"
					NAME !!L_XHTML11 VALUE "-//W3C//DTD XHTML 1.1//EN"
	END ITEMLIST
				NOSORT
	END PART
	EXPLAIN !!L_DefaultDoctypeExplain
	END POLICY
POLICY !!L_DefaultNewPageTypeOnSharePoint
KEYNAME "Software\Microsoft\Office\12.0\SharePoint Designer"
	PART !!L_Empty DROPDOWNLIST
				VALUENAME "New WSS Page Type"
	ITEMLIST
					NAME !!L_HTML VALUE "[HTML]"
					NAME !!L_ASPX VALUE "[ASPX]" DEFAULT
					NAME !!L_CSS VALUE "[CSS]"
					NAME !!L_XML VALUE "[XML]"
					NAME !!L_TextFile VALUE "[TEXT]"
	END ITEMLIST
				NOSORT
	END PART
	EXPLAIN !!L_DefaultNewPageTypeOnSharePointExplain
	END POLICY
POLICY !!L_DefaultSecondarySchema
KEYNAME "Software\Microsoft\Office\12.0\SharePoint Designer\Restrictions"
	PART !!L_Empty DROPDOWNLIST
				VALUENAME HTMLSchemaPath
	ITEMLIST
					NAME !!L_HTML401Strict VALUE "HTML_401.xsd"
					NAME !!L_HTML401Transitional VALUE "html_transitional_401.xsd"
					NAME !!L_HTML401Frameset VALUE "html_frameset_401.xsd"
					NAME !!L_XHTML10Strict VALUE "xhtml_strict-11.xsd"
					NAME !!L_XHTML10Transitional VALUE "xhtml_transitional.xsd"
					NAME !!L_XHTML10Frameset VALUE "xhtml_frameset.xsd"
					NAME !!L_XHTML11 VALUE "xhtml_strict-11.xsd"
					NAME !!L_InternetExplorer302 VALUE "ie3_2nav3_0.xsd"
					NAME !!L_InternetExplorer40 VALUE "N4.XSD"
					NAME !!L_InternetExplorer50 VALUE "IE5_0.XSD"
					NAME !!L_InternetExplorer60 VALUE "IE6_0.XSD" DEFAULT
	END ITEMLIST
				NOSORT
	END PART
	EXPLAIN !!L_DefaultSecondarySchemaExplain
	END POLICY
POLICY !!L_DefaultNewPageType
KEYNAME "Software\Microsoft\Office\12.0\SharePoint Designer"
	PART !!L_Empty DROPDOWNLIST
				VALUENAME "New Page Type"
	ITEMLIST
					NAME !!L_HTML VALUE "[HTML]"
					NAME !!L_ASPX VALUE "[ASPX]" DEFAULT
					NAME !!L_CSS VALUE "[CSS]"
					NAME !!L_XML VALUE "[XML]"
					NAME !!L_TextFile VALUE "[TEXT]"
	END ITEMLIST
				NOSORT
	END PART
	EXPLAIN !!L_DefaultNewPageTypeExplain
	END POLICY
END CATEGORY
CATEGORY !!L_DownloadingFrameworkComponents 
KEYNAME Software\Microsoft\Office\12.0
POLICY !!L_Hidemissingcomponentdownloadhyperlinks 
KEYNAME Software\Microsoft\Office\12.0\Common
		VALUENAME DisableMissingComponentHyperlinks
		VALUEON NUMERIC 1
		VALUEOFF NUMERIC 0
	EXPLAIN !!L_HidemissingcomponentdownloadhyperlinksExplain
	END POLICY
POLICY !!L_SetdownloadlocationforNET20framework 		
KEYNAME Software\Microsoft\Office\12.0\Common
	PART !!L_Empty EDITTEXT
				VALUENAME MissingFrameworkRedirect
	END PART
	EXPLAIN !!L_SetdownloadlocationforNET20frameworkExplain
	END POLICY
POLICY !!L_Setdownloadlocationforworkflowcomponent 
KEYNAME Software\Microsoft\Office\12.0\Common
	PART !!L_Empty EDITTEXT
				VALUENAME MissingWorkflowRedirect
	END PART
	EXPLAIN !!L_SetdownloadlocationforworkflowcomponentExplain
	END POLICY
END CATEGORY
CATEGORY !!L_Miscellaneous
KEYNAME "Software\Microsoft\Office\12.0\SharePoint Designer"
CATEGORY !!L_RemoteWebsiteProperties 
KEYNAME "Software\Microsoft\Office\12.0\SharePoint Designer"
POLICY !!L_DisableOptimizeHTMLonpublishcheckbox
KEYNAME "Software\Microsoft\Office\12.0\SharePoint Designer"
				VALUENAME DisableCleanOnPublish
				VALUEON "TRUE"
				VALUEOFF "FALSE"
	EXPLAIN !!L_DisablesEnablestheoptionWhenpublishingoptimizeHTMLbyremoving
	END POLICY
END CATEGORY
END CATEGORY
END CATEGORY


[Strings]
L_Empty=" "
L_Miscellaneous="Varios"
L_SetdownloadlocationforworkflowcomponentExplain="Establecer una ruta personalizada desde la que los usuarios puedan obtener acceso al componente que falta."
L_Setdownloadlocationforworkflowcomponent="Establecer ubicación de descarga para el componente del flujo de trabajo"
L_SetdownloadlocationforNET20frameworkExplain="Establecer una ruta personalizada desde la que los usuarios puedan obtener acceso al componente que falta."
L_SetdownloadlocationforNET20framework="Establecer ubicación de descarga para Microsoft .NET Framework 2.0"
L_DownloadingFrameworkComponents="Descargando componentes de Framework"
L_HidemissingcomponentdownloadhyperlinksExplain="No permitir la descarga de los componentes que faltan o no mostrar los hipervínculos de descarga de estos componentes. Es posible que falten los componentes Microsoft .NET Framework 2.0 y Workflow."
L_Hidemissingcomponentdownloadhyperlinks="Ocultar los hipervínculos de descarga del componente que falta"
L_None="Ninguno"
L_DefaultCSSSchemaExplain="Establecer el esquema CSS predeterminado que se va a utilizar para controlar IntelliSense y la cuadrícula de propiedades CSS."
L_DefaultCSSSchema="Esquema CSS predeterminado"
L_DefaultDoctypeExplain="Establecer el tipo de documento predeterminado en nuevas páginas."
L_DefaultDoctype="Tipo de documento predeterminado"
L_DefaultAuthoringOptions="Opciones de creación predeterminadas"
L_DefaultNewPageTypeOnSharePointExplain="Establecer el tipo de página el comando Nuevo documento creará al editar un sitio de SharePoint."
L_DefaultNewPageTypeOnSharePoint="Tipo de página nueva predeterminado en SharePoint"
L_DefaultSecondarySchema="Esquema secundario principal"
L_DefaultSecondarySchemaExplain="Establecer el esquema predeterminado que se utilizará cuando haya un tipo de documento no reconocido en la página o cuando no haya ninguno. El esquema controla IntelliSense, la cuadrícula de propiedades HTML y el comprobador de compatibilidad."
L_DefaultNewPageTypeExplain="Establecer el tipo de página que el comando Nuevo documento creará."
L_DefaultNewPageType="Tipo de página nueva predeterminado"
L_CSS1="CSS 1"
L_CSS2="CSS 2"
L_CSS21="CSS 2,1"
L_CSSIE6="CSS IE6"
L_HTML401Frameset="Conjunto de marcos de HTML 4.01"
L_HTML401Transitional="De transición de HTML 4.01"
L_HTML401Strict="Estricto de HTML 4.01"
L_XHTML10Frameset="Conjunto de marcos de XHTML 1.0"
L_XHTML10Transitional="De transición de XHTML 1.0"
L_XHTML10Strict="Estricto de XHTML 1.0"
L_XHTML11="XHTML 1.1"
L_HTML="HTML"
L_ASPX="ASPX"
L_CSS="CSS"
L_XML="XML"
L_TextFile="Archivo de texto"
L_InternetExplorer302="Microsoft Internet Explorer 3.02"
L_InternetExplorer40="Microsoft Internet Explorer 4"
L_InternetExplorer50="Microsoft Internet Explorer 5"
L_InternetExplorer60="Microsoft Internet Explorer 6"
L_DisableOptimizeHTMLonpublishcheckbox="Desactivar la casilla de verificación Optimizar HTML al publicar"
L_DisablesEnablestheoptionWhenpublishingoptimizeHTMLbyremoving="Deshabilita o habilita la opción ''Al publicar, optimizar el código HTML eliminando los elementos siguientes'' en la ficha Optimizar HTML del cuadro de diálogo Propiedades de sitio Web remoto (Archivo..comando Publicar sitio)."
L_MicrosoftOfficeSharePointDesigner12="Microsoft Office SharePoint Designer 2007"
L_RemoteWebsiteProperties="Propiedades del sitio Web remoto"


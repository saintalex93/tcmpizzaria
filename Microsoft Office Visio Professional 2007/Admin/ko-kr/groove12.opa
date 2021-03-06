;// _lcid="1033" _version="12.0.4518"
CLASS USER

CATEGORY !!L_Groove
POLICY !!L_GrooveAccountConfigurationCodeRequired 
KEYNAME Software\Microsoft\Office\Groove
		VALUENAME ConfigurationCodeRequired
				VALUEON NUMERIC 1
				VALUEOFF NUMERIC 0
	EXPLAIN !!L_GrooveAccountConfigurationCodeRequiredExplain
	END POLICY
CATEGORY !!L_GrooveMangager
POLICY !!L_GrooveManagerServerNamePolicy 
KEYNAME Software\Microsoft\Office\Groove\Manager
	PART !!L_Empty EDITTEXT
				VALUENAME ServerName
	END PART
	EXPLAIN !!L_GrooveManagerServerNameExplain
	END POLICY
END CATEGORY
END CATEGORY


[Strings]
L_Empty=" "
L_GrooveAccountConfigurationCodeRequired="Groove 계정 구성 코드 필요"
L_GrooveAccountConfigurationCodeRequiredExplain="계정을 만들 때는 계정 구성 코드를 사용하여 계정을 만들 것인지를 선택하는 옵션을 사용할 수 있습니다. 코드는 관리 ID를 통해 사용자를 완벽하게 지원합니다. 이 정책을 적용하면 Groove 클라이언트 UI에서 ''코드 없음'' 옵션을 사용할 수 없게 됩니다."
L_Groove="Microsoft Office Groove 2007"
L_GrooveMangager="Groove Manager"
L_GrooveManagerServerNamePolicy="Groove Manager 서버 이름"
L_GrooveManagerServerNameExplain="사용자의 Groove 관리 ID가 컴퓨터에 없는 경우 이 키를 사용하면 Groove가 지정된 Groove Manager 서버에 연결되고 Groove를 열 때 자동으로 관리 ID를 다운로드할 수 있습니다. 그렇게 하려면 Active Directory와의 디렉터리 통합을 사용하도록 구성된 Groove Manager를 온사이트로 설치해야 하며 Groove Enterprise Services에서는 그러한 기능이 작동하지 않습니다. 또한 새로 설치한 Groove 버전을 시작하고 컴퓨터에 Groove 계정이 없는 경우에만 컴퓨터에 사용자의 관리 ID가 다운로드됩니다."


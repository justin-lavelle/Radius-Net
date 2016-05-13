//
// System.Net.Radius.RadiusEnums.cs
//
// Author:
//  Cyrille Colin (colin@univ-metz.fr)
//
// Copyright (C) Cyrille COLIN, 2005
//


namespace System.Net.Radius {
	public enum RadiusPacketType {
	    ACCESS_REQUEST      = 1,
	    ACCESS_ACCEPT       = 2,
	    ACCESS_REJECT       = 3,
	    ACCOUNTING_REQUEST  = 4,
	    ACCOUNTING_RESPONSE = 5,
	    ACCOUNTING_STATUS   = 6,
	    PASSWORD_REQUEST    = 7,
	    PASSWORD_ACCEPT     = 8,
	  	PASSWORD_REJECT     = 9,
	    ACCOUNTING_MESSAGE  = 10,
	    ACCESS_CHALLENGE    = 11,
	}
	public enum RadiusAttributeType {
    	USER_NAME               = 1,
    	USER_PASSWORD           = 2,
    	CHAP_PASSWORD           = 3,
    	NAS_IP_ADDRESS          = 4,
    	NAS_PORT                = 5,
    	SERVICE_TYPE            = 6, // enum Service
    	FRAMED_PROTOCOL         = 7, // enum protocol
    	FRAMED_IP_ADDRESS       = 8,
    	FRAMED_IP_NETMASK       = 9,
    	FRAMED_ROUTING          = 10, // enum Routing
	    FILTER_ID               = 11,
    	FRAMED_MTU              = 12,
	    FRAMED_COMPRESSION      = 13, // enum Compression
    	LOGIN_IP_HOST           = 14,
	    LOGIN_SERVICE           = 15, // enum Login
    	LOGIN_TCP_PORT          = 16,
	    REPLY_MESSAGE           = 18,
	    CALLBACK_NUMBER         = 19,
	    CALLBACK_ID             = 20,
	    FRAMED_ROUTE            = 22,
	    FRAMED_IPX_NETWORK      = 23,
	    STATE                   = 24,
	    CLASS                   = 25,
	    VENDOR_SPECIFIC         = 26,
	    SESSION_TIMEOUT         = 27,
	    IDLE_TIMEOUT            = 28,
	    TERMINATION_ACTION      = 29,
	    CALLED_STATION_ID       = 30,
	    CALLING_STATION_ID      = 31,
	    NAS_IDENTIFIER          = 32,
	    PROXY_STATE             = 33,
	    LOGIN_LAT_SERVICE       = 34,
	    LOGIN_LAT_NODE          = 35,
	    LOGIN_LAT_GROUP         = 36,
	    FRAMED_APPLETALK_LINK       = 37,
	    FRAMED_APPLETALK_NETWORK    = 38,
	    FRAMED_APPLETALK_ZONE       = 39,
	    ACCT_STATUS_TYPE        = 40,
	    ACCT_DELAY_TIME         = 41,
	    ACCT_INPUT_OCTETS       = 42,
	    ACCT_OUTPUT_OCTETS      = 43,
	    ACCT_SESSION_ID         = 44,
	    ACCT_AUTHENTIC          = 45,
	    ACCT_SESSION_TIME       = 46,
	    ACCT_INPUT_PACKETS      = 47,
	    ACCT_OUTPUT_PACKETS     = 48,
	    ACCT_TERMINATE_CAUSE    = 49,
	    ACCT_MULTI_SESSION_ID   = 50,
	    ACCT_LINK_COUNT         = 51,
	    ACCT_INPUT_GIGAWORDS    = 52,
	    ACCT_OUTPUT_GIGAWORDS   = 53,
	    EVENT_TIMESTAMP         = 55,
	    CHAP_CHALLENGE      = 60,
	    NAS_PORT_TYPE       = 61,
	    PORT_LIMIT          = 62,
	    LOGIN_LAT_PORT      = 63,
	    ARAP_PASSWORD       = 70,
	    ARAP_FEATURES       = 71,
	    ARAP_ZONE_ACCESS    = 72,
	    ARAP_SECURITY       = 73,
	    ARAP_SECURITY_DATA  = 74,
	    PASSWORD_RETRY      = 75,
	    PROMPT              = 76,
	    CONNECT_INFO        = 77,
	    CONFIGURATION_TOKEN = 78,
	    EAP_MESSAGE         = 79,
	    MESSAGE_AUTHENTICATOR       = 80,
	    ARAP_CHALLENGE_RESPONSE     = 84,
	    ACCT_INTERIM_INTERVAL       = 85,
	    NAS_PORT_ID         = 87,
	    FRAMED_POOL         = 88
	}
	public enum Service {
	    LOGIN               =  1,
	    FRAMED              =  2,
	    CALLBACK_LOGIN      =  3,
	    CALLBACK_FRAMED     =  4,
	    OUTBOUND            =  5,
	    ADMINISTRATIVE      =  6,
	    NAS_PROMPT          =  7,
	    AUTHENTICATE_ONLY   =  8,
	    CALLBACK_NAS_PROMPT =  9,
	    CALL_CHECK          = 10,
	    CALLBACK_ADMINISTRATIVE = 11
	}
	public enum Protocol {
	    PPP                 = 1,
	    SLIP                = 2,
	    ARAP                = 3,
	    GANDALF_SLML        = 4,
	    XYLOGICS_PROPRIETARY_IPX_SLIP   = 5,
	    X75_SYNCHRONOUS     = 6	
	}
	public enum Routing {
		NONE                = 0,
	    BROADCAST           = 1,
	    LISTEN              = 2,
	    BROADCAST_LISTEN    = 3
	}
	public enum Compression {
	    VJ_TCP_IP_HEADER_COMPRESSION    = 1,
	    IPX_HEADER_COMPRESSION          = 2,
	    STAC_LZS_COMPRESSION            = 3
	}
	public enum Login {
	    TELNET          = 0,
	    RLOGIN          = 1,
	    TCP_CLEAR       = 2,
	    PORTMASTER      = 3,
	    LAT             = 4,
	    X25_PAD         = 5,
	    X25_T3POS       = 7,
	    TCP_CLEAR_QUIET = 8
	}
	public enum Termination {
	    DEFAULT         = 0,
	    RADIUS_REQUEST  = 1
	}
	public enum NasPortType {
	    ASYNC           =  0,
	    SYNC            =  1,
	    ISDN_SYNC       =  2,
	    ISDN_ASYNC_V120 =  3,
	    ISDN_ASYNC_V110 =  4,
	    VIRTUAL         =  5,
	    PIAFS           =  6,
	    HDLC_CLEAR_CHANNEL  =  7,
	    X25             =  8,
	    X75             =  9,
	    G3_FAX          = 10,
	    SDSL            = 11,
	    ADSL_CAP        = 12,
	    ADSL_DMT        = 13,
	    IDSL            = 14,
	    ETHERNET        = 15,
	    XDSL            = 16,
	    CABLE           = 17,
	    WIRELESS_OTHER  = 18,
	    WIRELESS_IEEE_802_11    = 19
	}
}

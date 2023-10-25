using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Connect
{
	// Token: 0x020005EE RID: 1518
	[Token(Token = "0x20005EE")]
	public sealed class ConnectInterface : Handle
	{
		// Token: 0x060026F2 RID: 9970 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026F2")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public ConnectInterface()
		{
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026F3")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public ConnectInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x00009E84 File Offset: 0x00008084
		[Token(Token = "0x60026F4")]
		[Address(RVA = "0x554E70", Offset = "0x553470", VA = "0x180554E70")]
		public ulong AddNotifyAuthExpiration(ref AddNotifyAuthExpirationOptions options, object clientData, OnAuthExpirationCallback notification)
		{
			return 0UL;
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x00009E9C File Offset: 0x0000809C
		[Token(Token = "0x60026F5")]
		[Address(RVA = "0x555030", Offset = "0x553630", VA = "0x180555030")]
		public ulong AddNotifyLoginStatusChanged(ref AddNotifyLoginStatusChangedOptions options, object clientData, OnLoginStatusChangedCallback notification)
		{
			return 0UL;
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x00009EB4 File Offset: 0x000080B4
		[Token(Token = "0x60026F6")]
		[Address(RVA = "0x5551F0", Offset = "0x5537F0", VA = "0x1805551F0")]
		public Result CopyIdToken(ref CopyIdTokenOptions options, out IdToken? outIdToken)
		{
			return Result.Success;
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x00009ECC File Offset: 0x000080CC
		[Token(Token = "0x60026F7")]
		[Address(RVA = "0x555320", Offset = "0x553920", VA = "0x180555320")]
		public Result CopyProductUserExternalAccountByAccountId(ref CopyProductUserExternalAccountByAccountIdOptions options, out ExternalAccountInfo? outExternalAccountInfo)
		{
			return Result.Success;
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x00009EE4 File Offset: 0x000080E4
		[Token(Token = "0x60026F8")]
		[Address(RVA = "0x555420", Offset = "0x553A20", VA = "0x180555420")]
		public Result CopyProductUserExternalAccountByAccountType(ref CopyProductUserExternalAccountByAccountTypeOptions options, out ExternalAccountInfo? outExternalAccountInfo)
		{
			return Result.Success;
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x00009EFC File Offset: 0x000080FC
		[Token(Token = "0x60026F9")]
		[Address(RVA = "0x555570", Offset = "0x553B70", VA = "0x180555570")]
		public Result CopyProductUserExternalAccountByIndex(ref CopyProductUserExternalAccountByIndexOptions options, out ExternalAccountInfo? outExternalAccountInfo)
		{
			return Result.Success;
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x00009F14 File Offset: 0x00008114
		[Token(Token = "0x60026FA")]
		[Address(RVA = "0x5556C0", Offset = "0x553CC0", VA = "0x1805556C0")]
		public Result CopyProductUserInfo(ref CopyProductUserInfoOptions options, out ExternalAccountInfo? outExternalAccountInfo)
		{
			return Result.Success;
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026FB")]
		[Address(RVA = "0x5557F0", Offset = "0x553DF0", VA = "0x1805557F0")]
		public void CreateDeviceId(ref CreateDeviceIdOptions options, object clientData, OnCreateDeviceIdCallback completionDelegate)
		{
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026FC")]
		[Address(RVA = "0x5559F0", Offset = "0x553FF0", VA = "0x1805559F0")]
		public void CreateUser(ref CreateUserOptions options, object clientData, OnCreateUserCallback completionDelegate)
		{
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026FD")]
		[Address(RVA = "0x555BF0", Offset = "0x5541F0", VA = "0x180555BF0")]
		public void DeleteDeviceId(ref DeleteDeviceIdOptions options, object clientData, OnDeleteDeviceIdCallback completionDelegate)
		{
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x60026FE")]
		[Address(RVA = "0x555DA0", Offset = "0x5543A0", VA = "0x180555DA0")]
		public ProductUserId GetExternalAccountMapping(ref GetExternalAccountMappingsOptions options)
		{
			return null;
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x60026FF")]
		[Address(RVA = "0x555E70", Offset = "0x554470", VA = "0x180555E70")]
		public ProductUserId GetLoggedInUserByIndex(int index)
		{
			return null;
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x00009F2C File Offset: 0x0000812C
		[Token(Token = "0x6002700")]
		[Address(RVA = "0x555F00", Offset = "0x554500", VA = "0x180555F00")]
		public int GetLoggedInUsersCount()
		{
			return 0;
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x00009F44 File Offset: 0x00008144
		[Token(Token = "0x6002701")]
		[Address(RVA = "0x555F10", Offset = "0x554510", VA = "0x180555F10")]
		public LoginStatus GetLoginStatus(ProductUserId localUserId)
		{
			return LoginStatus.NotLoggedIn;
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x00009F5C File Offset: 0x0000815C
		[Token(Token = "0x6002702")]
		[Address(RVA = "0x555F90", Offset = "0x554590", VA = "0x180555F90")]
		public uint GetProductUserExternalAccountCount(ref GetProductUserExternalAccountCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x00009F74 File Offset: 0x00008174
		[Token(Token = "0x6002703")]
		[Address(RVA = "0x556070", Offset = "0x554670", VA = "0x180556070")]
		public Result GetProductUserIdMapping(ref GetProductUserIdMappingOptions options, out Utf8String outBuffer)
		{
			return Result.Success;
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002704")]
		[Address(RVA = "0x556160", Offset = "0x554760", VA = "0x180556160")]
		public void LinkAccount(ref LinkAccountOptions options, object clientData, OnLinkAccountCallback completionDelegate)
		{
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002705")]
		[Address(RVA = "0x556330", Offset = "0x554930", VA = "0x180556330")]
		public void Login(ref LoginOptions options, object clientData, OnLoginCallback completionDelegate)
		{
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002706")]
		[Address(RVA = "0x556CB0", Offset = "0x5552B0", VA = "0x180556CB0")]
		public void QueryExternalAccountMappings(ref QueryExternalAccountMappingsOptions options, object clientData, OnQueryExternalAccountMappingsCallback completionDelegate)
		{
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002707")]
		[Address(RVA = "0x556F20", Offset = "0x555520", VA = "0x180556F20")]
		public void QueryProductUserIdMappings(ref QueryProductUserIdMappingsOptions options, object clientData, OnQueryProductUserIdMappingsCallback completionDelegate)
		{
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002708")]
		[Address(RVA = "0x557190", Offset = "0x555790", VA = "0x180557190")]
		public void RemoveNotifyAuthExpiration(ulong inId)
		{
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002709")]
		[Address(RVA = "0x557200", Offset = "0x555800", VA = "0x180557200")]
		public void RemoveNotifyLoginStatusChanged(ulong inId)
		{
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600270A")]
		[Address(RVA = "0x557270", Offset = "0x555870", VA = "0x180557270")]
		public void TransferDeviceIdAccount(ref TransferDeviceIdAccountOptions options, object clientData, OnTransferDeviceIdAccountCallback completionDelegate)
		{
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600270B")]
		[Address(RVA = "0x557440", Offset = "0x555A40", VA = "0x180557440")]
		public void UnlinkAccount(ref UnlinkAccountOptions options, object clientData, OnUnlinkAccountCallback completionDelegate)
		{
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600270C")]
		[Address(RVA = "0x557640", Offset = "0x555C40", VA = "0x180557640")]
		public void VerifyIdToken(ref VerifyIdTokenOptions options, object clientData, OnVerifyIdTokenCallback completionDelegate)
		{
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600270D")]
		[Address(RVA = "0x556500", Offset = "0x554B00", VA = "0x180556500")]
		[MonoPInvokeCallback(typeof(OnAuthExpirationCallbackInternal))]
		internal static void OnAuthExpirationCallbackInternalImplementation(ref AuthExpirationCallbackInfoInternal data)
		{
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600270E")]
		[Address(RVA = "0x5565A0", Offset = "0x554BA0", VA = "0x1805565A0")]
		[MonoPInvokeCallback(typeof(OnCreateDeviceIdCallbackInternal))]
		internal static void OnCreateDeviceIdCallbackInternalImplementation(ref CreateDeviceIdCallbackInfoInternal data)
		{
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600270F")]
		[Address(RVA = "0x556640", Offset = "0x554C40", VA = "0x180556640")]
		[MonoPInvokeCallback(typeof(OnCreateUserCallbackInternal))]
		internal static void OnCreateUserCallbackInternalImplementation(ref CreateUserCallbackInfoInternal data)
		{
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002710")]
		[Address(RVA = "0x5566E0", Offset = "0x554CE0", VA = "0x1805566E0")]
		[MonoPInvokeCallback(typeof(OnDeleteDeviceIdCallbackInternal))]
		internal static void OnDeleteDeviceIdCallbackInternalImplementation(ref DeleteDeviceIdCallbackInfoInternal data)
		{
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002711")]
		[Address(RVA = "0x556780", Offset = "0x554D80", VA = "0x180556780")]
		[MonoPInvokeCallback(typeof(OnLinkAccountCallbackInternal))]
		internal static void OnLinkAccountCallbackInternalImplementation(ref LinkAccountCallbackInfoInternal data)
		{
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002712")]
		[Address(RVA = "0x556820", Offset = "0x554E20", VA = "0x180556820")]
		[MonoPInvokeCallback(typeof(OnLoginCallbackInternal))]
		internal static void OnLoginCallbackInternalImplementation(ref LoginCallbackInfoInternal data)
		{
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002713")]
		[Address(RVA = "0x5568C0", Offset = "0x554EC0", VA = "0x1805568C0")]
		[MonoPInvokeCallback(typeof(OnLoginStatusChangedCallbackInternal))]
		internal static void OnLoginStatusChangedCallbackInternalImplementation(ref LoginStatusChangedCallbackInfoInternal data)
		{
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002714")]
		[Address(RVA = "0x556960", Offset = "0x554F60", VA = "0x180556960")]
		[MonoPInvokeCallback(typeof(OnQueryExternalAccountMappingsCallbackInternal))]
		internal static void OnQueryExternalAccountMappingsCallbackInternalImplementation(ref QueryExternalAccountMappingsCallbackInfoInternal data)
		{
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002715")]
		[Address(RVA = "0x556A00", Offset = "0x555000", VA = "0x180556A00")]
		[MonoPInvokeCallback(typeof(OnQueryProductUserIdMappingsCallbackInternal))]
		internal static void OnQueryProductUserIdMappingsCallbackInternalImplementation(ref QueryProductUserIdMappingsCallbackInfoInternal data)
		{
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002716")]
		[Address(RVA = "0x556AA0", Offset = "0x5550A0", VA = "0x180556AA0")]
		[MonoPInvokeCallback(typeof(OnTransferDeviceIdAccountCallbackInternal))]
		internal static void OnTransferDeviceIdAccountCallbackInternalImplementation(ref TransferDeviceIdAccountCallbackInfoInternal data)
		{
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002717")]
		[Address(RVA = "0x556B40", Offset = "0x555140", VA = "0x180556B40")]
		[MonoPInvokeCallback(typeof(OnUnlinkAccountCallbackInternal))]
		internal static void OnUnlinkAccountCallbackInternalImplementation(ref UnlinkAccountCallbackInfoInternal data)
		{
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002718")]
		[Address(RVA = "0x556BE0", Offset = "0x5551E0", VA = "0x180556BE0")]
		[MonoPInvokeCallback(typeof(OnVerifyIdTokenCallbackInternal))]
		internal static void OnVerifyIdTokenCallbackInternalImplementation(ref VerifyIdTokenCallbackInfoInternal data)
		{
		}

		// Token: 0x0400110B RID: 4363
		[Token(Token = "0x400110B")]
		public const int AddnotifyauthexpirationApiLatest = 1;

		// Token: 0x0400110C RID: 4364
		[Token(Token = "0x400110C")]
		public const int AddnotifyloginstatuschangedApiLatest = 1;

		// Token: 0x0400110D RID: 4365
		[Token(Token = "0x400110D")]
		public const int CopyidtokenApiLatest = 1;

		// Token: 0x0400110E RID: 4366
		[Token(Token = "0x400110E")]
		public const int CopyproductuserexternalaccountbyaccountidApiLatest = 1;

		// Token: 0x0400110F RID: 4367
		[Token(Token = "0x400110F")]
		public const int CopyproductuserexternalaccountbyaccounttypeApiLatest = 1;

		// Token: 0x04001110 RID: 4368
		[Token(Token = "0x4001110")]
		public const int CopyproductuserexternalaccountbyindexApiLatest = 1;

		// Token: 0x04001111 RID: 4369
		[Token(Token = "0x4001111")]
		public const int CopyproductuserinfoApiLatest = 1;

		// Token: 0x04001112 RID: 4370
		[Token(Token = "0x4001112")]
		public const int CreatedeviceidApiLatest = 1;

		// Token: 0x04001113 RID: 4371
		[Token(Token = "0x4001113")]
		public const int CreatedeviceidDevicemodelMaxLength = 64;

		// Token: 0x04001114 RID: 4372
		[Token(Token = "0x4001114")]
		public const int CreateuserApiLatest = 1;

		// Token: 0x04001115 RID: 4373
		[Token(Token = "0x4001115")]
		public const int CredentialsApiLatest = 1;

		// Token: 0x04001116 RID: 4374
		[Token(Token = "0x4001116")]
		public const int DeletedeviceidApiLatest = 1;

		// Token: 0x04001117 RID: 4375
		[Token(Token = "0x4001117")]
		public const int ExternalAccountIdMaxLength = 256;

		// Token: 0x04001118 RID: 4376
		[Token(Token = "0x4001118")]
		public const int ExternalaccountinfoApiLatest = 1;

		// Token: 0x04001119 RID: 4377
		[Token(Token = "0x4001119")]
		public const int GetexternalaccountmappingApiLatest = 1;

		// Token: 0x0400111A RID: 4378
		[Token(Token = "0x400111A")]
		public const int GetexternalaccountmappingsApiLatest = 1;

		// Token: 0x0400111B RID: 4379
		[Token(Token = "0x400111B")]
		public const int GetproductuserexternalaccountcountApiLatest = 1;

		// Token: 0x0400111C RID: 4380
		[Token(Token = "0x400111C")]
		public const int GetproductuseridmappingApiLatest = 1;

		// Token: 0x0400111D RID: 4381
		[Token(Token = "0x400111D")]
		public const int IdtokenApiLatest = 1;

		// Token: 0x0400111E RID: 4382
		[Token(Token = "0x400111E")]
		public const int LinkaccountApiLatest = 1;

		// Token: 0x0400111F RID: 4383
		[Token(Token = "0x400111F")]
		public const int LoginApiLatest = 2;

		// Token: 0x04001120 RID: 4384
		[Token(Token = "0x4001120")]
		public const int OnauthexpirationcallbackApiLatest = 1;

		// Token: 0x04001121 RID: 4385
		[Token(Token = "0x4001121")]
		public const int QueryexternalaccountmappingsApiLatest = 1;

		// Token: 0x04001122 RID: 4386
		[Token(Token = "0x4001122")]
		public const int QueryexternalaccountmappingsMaxAccountIds = 128;

		// Token: 0x04001123 RID: 4387
		[Token(Token = "0x4001123")]
		public const int QueryproductuseridmappingsApiLatest = 2;

		// Token: 0x04001124 RID: 4388
		[Token(Token = "0x4001124")]
		public const int TimeUndefined = -1;

		// Token: 0x04001125 RID: 4389
		[Token(Token = "0x4001125")]
		public const int TransferdeviceidaccountApiLatest = 1;

		// Token: 0x04001126 RID: 4390
		[Token(Token = "0x4001126")]
		public const int UnlinkaccountApiLatest = 1;

		// Token: 0x04001127 RID: 4391
		[Token(Token = "0x4001127")]
		public const int UserlogininfoApiLatest = 2;

		// Token: 0x04001128 RID: 4392
		[Token(Token = "0x4001128")]
		public const int UserlogininfoDisplaynameMaxLength = 32;

		// Token: 0x04001129 RID: 4393
		[Token(Token = "0x4001129")]
		public const int VerifyidtokenApiLatest = 1;
	}
}

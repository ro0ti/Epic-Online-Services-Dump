using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200064D RID: 1613
	[Token(Token = "0x200064D")]
	public sealed class AuthInterface : Handle
	{
		// Token: 0x06002950 RID: 10576 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002950")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public AuthInterface()
		{
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002951")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public AuthInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x0000A5A4 File Offset: 0x000087A4
		[Token(Token = "0x6002952")]
		[Address(RVA = "0x5533E0", Offset = "0x5519E0", VA = "0x1805533E0")]
		public ulong AddNotifyLoginStatusChanged(ref AddNotifyLoginStatusChangedOptions options, object clientData, OnLoginStatusChangedCallback notification)
		{
			return 0UL;
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x0000A5BC File Offset: 0x000087BC
		[Token(Token = "0x6002953")]
		[Address(RVA = "0x5535A0", Offset = "0x551BA0", VA = "0x1805535A0")]
		public Result CopyIdToken(ref CopyIdTokenOptions options, out IdToken? outIdToken)
		{
			return Result.Success;
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x0000A5D4 File Offset: 0x000087D4
		[Token(Token = "0x6002954")]
		[Address(RVA = "0x5536D0", Offset = "0x551CD0", VA = "0x1805536D0")]
		public Result CopyUserAuthToken(ref CopyUserAuthTokenOptions options, EpicAccountId localUserId, out Token? outUserAuthToken)
		{
			return Result.Success;
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002955")]
		[Address(RVA = "0x5537D0", Offset = "0x551DD0", VA = "0x1805537D0")]
		public void DeletePersistentAuth(ref DeletePersistentAuthOptions options, object clientData, OnDeletePersistentAuthCallback completionDelegate)
		{
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002956")]
		[Address(RVA = "0x5539D0", Offset = "0x551FD0", VA = "0x1805539D0")]
		public EpicAccountId GetLoggedInAccountByIndex(int index)
		{
			return null;
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x0000A5EC File Offset: 0x000087EC
		[Token(Token = "0x6002957")]
		[Address(RVA = "0x553A60", Offset = "0x552060", VA = "0x180553A60")]
		public int GetLoggedInAccountsCount()
		{
			return 0;
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x0000A604 File Offset: 0x00008804
		[Token(Token = "0x6002958")]
		[Address(RVA = "0x553A70", Offset = "0x552070", VA = "0x180553A70")]
		public LoginStatus GetLoginStatus(EpicAccountId localUserId)
		{
			return LoginStatus.NotLoggedIn;
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002959")]
		[Address(RVA = "0x553AF0", Offset = "0x5520F0", VA = "0x180553AF0")]
		public EpicAccountId GetMergedAccountByIndex(EpicAccountId localUserId, uint index)
		{
			return null;
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x0000A61C File Offset: 0x0000881C
		[Token(Token = "0x600295A")]
		[Address(RVA = "0x553BA0", Offset = "0x5521A0", VA = "0x180553BA0")]
		public uint GetMergedAccountsCount(EpicAccountId localUserId)
		{
			return 0U;
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x0000A634 File Offset: 0x00008834
		[Token(Token = "0x600295B")]
		[Address(RVA = "0x553C20", Offset = "0x552220", VA = "0x180553C20")]
		public Result GetSelectedAccountId(EpicAccountId localUserId, out EpicAccountId outSelectedAccountId)
		{
			return Result.Success;
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600295C")]
		[Address(RVA = "0x553CE0", Offset = "0x5522E0", VA = "0x180553CE0")]
		public void LinkAccount(ref LinkAccountOptions options, object clientData, OnLinkAccountCallback completionDelegate)
		{
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600295D")]
		[Address(RVA = "0x554080", Offset = "0x552680", VA = "0x180554080")]
		public void Login(ref LoginOptions options, object clientData, OnLoginCallback completionDelegate)
		{
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600295E")]
		[Address(RVA = "0x5542C0", Offset = "0x5528C0", VA = "0x1805542C0")]
		public void Logout(ref LogoutOptions options, object clientData, OnLogoutCallback completionDelegate)
		{
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600295F")]
		[Address(RVA = "0x554A40", Offset = "0x553040", VA = "0x180554A40")]
		public void QueryIdToken(ref QueryIdTokenOptions options, object clientData, OnQueryIdTokenCallback completionDelegate)
		{
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002960")]
		[Address(RVA = "0x554B80", Offset = "0x553180", VA = "0x180554B80")]
		public void RemoveNotifyLoginStatusChanged(ulong inId)
		{
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002961")]
		[Address(RVA = "0x554BF0", Offset = "0x5531F0", VA = "0x180554BF0")]
		public void VerifyIdToken(ref VerifyIdTokenOptions options, object clientData, OnVerifyIdTokenCallback completionDelegate)
		{
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002962")]
		[Address(RVA = "0x554D30", Offset = "0x553330", VA = "0x180554D30")]
		public void VerifyUserAuth(ref VerifyUserAuthOptions options, object clientData, OnVerifyUserAuthCallback completionDelegate)
		{
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002963")]
		[Address(RVA = "0x5544C0", Offset = "0x552AC0", VA = "0x1805544C0")]
		[MonoPInvokeCallback(typeof(OnDeletePersistentAuthCallbackInternal))]
		internal static void OnDeletePersistentAuthCallbackInternalImplementation(ref DeletePersistentAuthCallbackInfoInternal data)
		{
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002964")]
		[Address(RVA = "0x554560", Offset = "0x552B60", VA = "0x180554560")]
		[MonoPInvokeCallback(typeof(OnLinkAccountCallbackInternal))]
		internal static void OnLinkAccountCallbackInternalImplementation(ref LinkAccountCallbackInfoInternal data)
		{
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002965")]
		[Address(RVA = "0x554620", Offset = "0x552C20", VA = "0x180554620")]
		[MonoPInvokeCallback(typeof(OnLoginCallbackInternal))]
		internal static void OnLoginCallbackInternalImplementation(ref LoginCallbackInfoInternal data)
		{
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002966")]
		[Address(RVA = "0x5546F0", Offset = "0x552CF0", VA = "0x1805546F0")]
		[MonoPInvokeCallback(typeof(OnLoginStatusChangedCallbackInternal))]
		internal static void OnLoginStatusChangedCallbackInternalImplementation(ref LoginStatusChangedCallbackInfoInternal data)
		{
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002967")]
		[Address(RVA = "0x554790", Offset = "0x552D90", VA = "0x180554790")]
		[MonoPInvokeCallback(typeof(OnLogoutCallbackInternal))]
		internal static void OnLogoutCallbackInternalImplementation(ref LogoutCallbackInfoInternal data)
		{
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002968")]
		[Address(RVA = "0x554830", Offset = "0x552E30", VA = "0x180554830")]
		[MonoPInvokeCallback(typeof(OnQueryIdTokenCallbackInternal))]
		internal static void OnQueryIdTokenCallbackInternalImplementation(ref QueryIdTokenCallbackInfoInternal data)
		{
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002969")]
		[Address(RVA = "0x5548D0", Offset = "0x552ED0", VA = "0x1805548D0")]
		[MonoPInvokeCallback(typeof(OnVerifyIdTokenCallbackInternal))]
		internal static void OnVerifyIdTokenCallbackInternalImplementation(ref VerifyIdTokenCallbackInfoInternal data)
		{
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600296A")]
		[Address(RVA = "0x5549A0", Offset = "0x552FA0", VA = "0x1805549A0")]
		[MonoPInvokeCallback(typeof(OnVerifyUserAuthCallbackInternal))]
		internal static void OnVerifyUserAuthCallbackInternalImplementation(ref VerifyUserAuthCallbackInfoInternal data)
		{
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600296B")]
		[Address(RVA = "0x553EB0", Offset = "0x5524B0", VA = "0x180553EB0")]
		public void Login(ref IOSLoginOptions options, object clientData, OnLoginCallback completionDelegate)
		{
		}

		// Token: 0x040011F0 RID: 4592
		[Token(Token = "0x40011F0")]
		public const int AccountfeaturerestrictedinfoApiLatest = 1;

		// Token: 0x040011F1 RID: 4593
		[Token(Token = "0x40011F1")]
		public const int AddnotifyloginstatuschangedApiLatest = 1;

		// Token: 0x040011F2 RID: 4594
		[Token(Token = "0x40011F2")]
		public const int CopyidtokenApiLatest = 1;

		// Token: 0x040011F3 RID: 4595
		[Token(Token = "0x40011F3")]
		public const int CopyuserauthtokenApiLatest = 1;

		// Token: 0x040011F4 RID: 4596
		[Token(Token = "0x40011F4")]
		public const int CredentialsApiLatest = 4;

		// Token: 0x040011F5 RID: 4597
		[Token(Token = "0x40011F5")]
		public const int DeletepersistentauthApiLatest = 2;

		// Token: 0x040011F6 RID: 4598
		[Token(Token = "0x40011F6")]
		public const int IdtokenApiLatest = 1;

		// Token: 0x040011F7 RID: 4599
		[Token(Token = "0x40011F7")]
		public const int LinkaccountApiLatest = 1;

		// Token: 0x040011F8 RID: 4600
		[Token(Token = "0x40011F8")]
		public const int LoginApiLatest = 3;

		// Token: 0x040011F9 RID: 4601
		[Token(Token = "0x40011F9")]
		public const int LogoutApiLatest = 1;

		// Token: 0x040011FA RID: 4602
		[Token(Token = "0x40011FA")]
		public const int PingrantinfoApiLatest = 2;

		// Token: 0x040011FB RID: 4603
		[Token(Token = "0x40011FB")]
		public const int QueryidtokenApiLatest = 1;

		// Token: 0x040011FC RID: 4604
		[Token(Token = "0x40011FC")]
		public const int TokenApiLatest = 2;

		// Token: 0x040011FD RID: 4605
		[Token(Token = "0x40011FD")]
		public const int VerifyidtokenApiLatest = 1;

		// Token: 0x040011FE RID: 4606
		[Token(Token = "0x40011FE")]
		public const int VerifyuserauthApiLatest = 1;

		// Token: 0x040011FF RID: 4607
		[Token(Token = "0x40011FF")]
		public const int IosCredentialssystemauthcredentialsoptionsApiLatest = 1;
	}
}

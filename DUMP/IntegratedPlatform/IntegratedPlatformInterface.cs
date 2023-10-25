using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004E0 RID: 1248
	[Token(Token = "0x20004E0")]
	public sealed class IntegratedPlatformInterface : Handle
	{
		// Token: 0x06002007 RID: 8199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002007")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public IntegratedPlatformInterface()
		{
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002008")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public IntegratedPlatformInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x000089CC File Offset: 0x00006BCC
		[Token(Token = "0x6002009")]
		[Address(RVA = "0x5240F0", Offset = "0x5226F0", VA = "0x1805240F0")]
		public ulong AddNotifyUserLoginStatusChanged(ref AddNotifyUserLoginStatusChangedOptions options, object clientData, OnUserLoginStatusChangedCallback callbackFunction)
		{
			return 0UL;
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600200A")]
		[Address(RVA = "0x5242B0", Offset = "0x5228B0", VA = "0x1805242B0")]
		public void ClearUserPreLogoutCallback(ref ClearUserPreLogoutCallbackOptions options)
		{
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x000089E4 File Offset: 0x00006BE4
		[Token(Token = "0x600200B")]
		[Address(RVA = "0x524330", Offset = "0x522930", VA = "0x180524330")]
		public static Result CreateIntegratedPlatformOptionsContainer(ref CreateIntegratedPlatformOptionsContainerOptions options, out IntegratedPlatformOptionsContainer outIntegratedPlatformOptionsContainerHandle)
		{
			return Result.Success;
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x000089FC File Offset: 0x00006BFC
		[Token(Token = "0x600200C")]
		[Address(RVA = "0x5243F0", Offset = "0x5229F0", VA = "0x1805243F0")]
		public Result FinalizeDeferredUserLogout(ref FinalizeDeferredUserLogoutOptions options)
		{
			return Result.Success;
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600200D")]
		[Address(RVA = "0x524620", Offset = "0x522C20", VA = "0x180524620")]
		public void RemoveNotifyUserLoginStatusChanged(ulong notificationId)
		{
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x00008A14 File Offset: 0x00006C14
		[Token(Token = "0x600200E")]
		[Address(RVA = "0x524690", Offset = "0x522C90", VA = "0x180524690")]
		public Result SetUserLoginStatus(ref SetUserLoginStatusOptions options)
		{
			return Result.Success;
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x00008A2C File Offset: 0x00006C2C
		[Token(Token = "0x600200F")]
		[Address(RVA = "0x524730", Offset = "0x522D30", VA = "0x180524730")]
		public Result SetUserPreLogoutCallback(ref SetUserPreLogoutCallbackOptions options, object clientData, OnUserPreLogoutCallback callbackFunction)
		{
			return Result.Success;
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002010")]
		[Address(RVA = "0x524490", Offset = "0x522A90", VA = "0x180524490")]
		[MonoPInvokeCallback(typeof(OnUserLoginStatusChangedCallbackInternal))]
		internal static void OnUserLoginStatusChangedCallbackInternalImplementation(ref UserLoginStatusChangedCallbackInfoInternal data)
		{
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x00008A44 File Offset: 0x00006C44
		[Token(Token = "0x6002011")]
		[Address(RVA = "0x524540", Offset = "0x522B40", VA = "0x180524540")]
		[MonoPInvokeCallback(typeof(OnUserPreLogoutCallbackInternal))]
		internal static IntegratedPlatformPreLogoutAction OnUserPreLogoutCallbackInternalImplementation(ref UserPreLogoutCallbackInfoInternal data)
		{
			return IntegratedPlatformPreLogoutAction.ProcessLogoutImmediately;
		}

		// Token: 0x04000E22 RID: 3618
		[Token(Token = "0x4000E22")]
		public const int AddnotifyuserloginstatuschangedApiLatest = 1;

		// Token: 0x04000E23 RID: 3619
		[Token(Token = "0x4000E23")]
		public const int ClearuserprelogoutcallbackApiLatest = 1;

		// Token: 0x04000E24 RID: 3620
		[Token(Token = "0x4000E24")]
		public const int CreateintegratedplatformoptionscontainerApiLatest = 1;

		// Token: 0x04000E25 RID: 3621
		[Token(Token = "0x4000E25")]
		public const int FinalizedeferreduserlogoutApiLatest = 1;

		// Token: 0x04000E26 RID: 3622
		[Token(Token = "0x4000E26")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Utf8String IptSteam;

		// Token: 0x04000E27 RID: 3623
		[Token(Token = "0x4000E27")]
		public const int OptionsApiLatest = 1;

		// Token: 0x04000E28 RID: 3624
		[Token(Token = "0x4000E28")]
		public const int SetuserloginstatusApiLatest = 1;

		// Token: 0x04000E29 RID: 3625
		[Token(Token = "0x4000E29")]
		public const int SetuserprelogoutcallbackApiLatest = 1;

		// Token: 0x04000E2A RID: 3626
		[Token(Token = "0x4000E2A")]
		public const int SteamOptionsApiLatest = 2;
	}
}

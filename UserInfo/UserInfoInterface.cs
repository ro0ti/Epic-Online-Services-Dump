using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	public sealed class UserInfoInterface : Handle
	{
		// Token: 0x060004A2 RID: 1186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x3E4E80", Offset = "0x3E3480", VA = "0x1803E4E80")]
		public UserInfoInterface()
		{
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x49FCF0", Offset = "0x49E2F0", VA = "0x18049FCF0")]
		public UserInfoInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x000027EC File Offset: 0x000009EC
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x4B5BB0", Offset = "0x4B41B0", VA = "0x1804B5BB0")]
		public Result CopyBestDisplayName(ref CopyBestDisplayNameOptions options, out BestDisplayName? outBestDisplayName)
		{
			return Result.Success;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00002804 File Offset: 0x00000A04
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x4B5920", Offset = "0x4B3F20", VA = "0x1804B5920")]
		public Result CopyBestDisplayNameWithPlatform(ref CopyBestDisplayNameWithPlatformOptions options, out BestDisplayName? outBestDisplayName)
		{
			return Result.Success;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0000281C File Offset: 0x00000A1C
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x4B5E30", Offset = "0x4B4430", VA = "0x1804B5E30")]
		public Result CopyExternalUserInfoByAccountId(ref CopyExternalUserInfoByAccountIdOptions options, out ExternalUserInfo? outExternalUserInfo)
		{
			return Result.Success;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00002834 File Offset: 0x00000A34
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x4B6100", Offset = "0x4B4700", VA = "0x1804B6100")]
		public Result CopyExternalUserInfoByAccountType(ref CopyExternalUserInfoByAccountTypeOptions options, out ExternalUserInfo? outExternalUserInfo)
		{
			return Result.Success;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0000284C File Offset: 0x00000A4C
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x4B6390", Offset = "0x4B4990", VA = "0x1804B6390")]
		public Result CopyExternalUserInfoByIndex(ref CopyExternalUserInfoByIndexOptions options, out ExternalUserInfo? outExternalUserInfo)
		{
			return Result.Success;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00002864 File Offset: 0x00000A64
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x4B6620", Offset = "0x4B4C20", VA = "0x1804B6620")]
		public Result CopyUserInfo(ref CopyUserInfoOptions options, out UserInfoData? outUserInfo)
		{
			return Result.Success;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0000287C File Offset: 0x00000A7C
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x4B68E0", Offset = "0x4B4EE0", VA = "0x1804B68E0")]
		public uint GetExternalUserInfoCount(ref GetExternalUserInfoCountOptions options)
		{
			return 0U;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002894 File Offset: 0x00000A94
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x4B6B00", Offset = "0x4B5100", VA = "0x1804B6B00")]
		public uint GetLocalPlatformType(ref GetLocalPlatformTypeOptions options)
		{
			return 0U;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x4B73F0", Offset = "0x4B59F0", VA = "0x1804B73F0")]
		public void QueryUserInfo(ref QueryUserInfoOptions options, object clientData, OnQueryUserInfoCallback completionDelegate)
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x4B6DE0", Offset = "0x4B53E0", VA = "0x1804B6DE0")]
		public void QueryUserInfoByDisplayName(ref QueryUserInfoByDisplayNameOptions options, object clientData, OnQueryUserInfoByDisplayNameCallback completionDelegate)
		{
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x4B70E0", Offset = "0x4B56E0", VA = "0x1804B70E0")]
		public void QueryUserInfoByExternalAccount(ref QueryUserInfoByExternalAccountOptions options, object clientData, OnQueryUserInfoByExternalAccountCallback completionDelegate)
		{
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x4B6BE0", Offset = "0x4B51E0", VA = "0x1804B6BE0")]
		[MonoPInvokeCallback(typeof(OnQueryUserInfoByDisplayNameCallbackInternal))]
		internal static void OnQueryUserInfoByDisplayNameCallbackInternalImplementation(ref QueryUserInfoByDisplayNameCallbackInfoInternal data)
		{
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x4B6C90", Offset = "0x4B5290", VA = "0x1804B6C90")]
		[MonoPInvokeCallback(typeof(OnQueryUserInfoByExternalAccountCallbackInternal))]
		internal static void OnQueryUserInfoByExternalAccountCallbackInternalImplementation(ref QueryUserInfoByExternalAccountCallbackInfoInternal data)
		{
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x4B6D40", Offset = "0x4B5340", VA = "0x1804B6D40")]
		[MonoPInvokeCallback(typeof(OnQueryUserInfoCallbackInternal))]
		internal static void OnQueryUserInfoCallbackInternalImplementation(ref QueryUserInfoCallbackInfoInternal data)
		{
		}

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		public const int BestdisplaynameApiLatest = 1;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		public const int CopybestdisplaynameApiLatest = 1;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		public const int CopybestdisplaynamewithplatformApiLatest = 1;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		public const int CopyexternaluserinfobyaccountidApiLatest = 1;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		public const int CopyexternaluserinfobyaccounttypeApiLatest = 1;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		public const int CopyexternaluserinfobyindexApiLatest = 1;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		public const int CopyuserinfoApiLatest = 3;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		public const int ExternaluserinfoApiLatest = 2;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		public const int GetexternaluserinfocountApiLatest = 1;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		public const int GetlocalplatformtypeApiLatest = 1;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		public const int MaxDisplaynameCharacters = 16;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		public const int MaxDisplaynameUtf8Length = 64;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		public const int QueryuserinfoApiLatest = 1;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		public const int QueryuserinfobydisplaynameApiLatest = 1;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		public const int QueryuserinfobyexternalaccountApiLatest = 1;
	}
}

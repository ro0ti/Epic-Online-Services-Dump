using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200016C RID: 364
	[Token(Token = "0x200016C")]
	public sealed class SessionModification : Handle
	{
		// Token: 0x06000AE9 RID: 2793 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public SessionModification()
		{
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public SessionModification(IntPtr innerHandle)
		{
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00003EE4 File Offset: 0x000020E4
		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x4CB700", Offset = "0x4C9D00", VA = "0x1804CB700")]
		public Result AddAttribute(ref SessionModificationAddAttributeOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x4CB830", Offset = "0x4C9E30", VA = "0x1804CB830")]
		public void Release()
		{
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00003EFC File Offset: 0x000020FC
		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x4CB840", Offset = "0x4C9E40", VA = "0x1804CB840")]
		public Result RemoveAttribute(ref SessionModificationRemoveAttributeOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00003F14 File Offset: 0x00002114
		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x4CB920", Offset = "0x4C9F20", VA = "0x1804CB920")]
		public Result SetAllowedPlatformIds(ref SessionModificationSetAllowedPlatformIdsOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00003F2C File Offset: 0x0000212C
		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x4CBA10", Offset = "0x4CA010", VA = "0x1804CBA10")]
		public Result SetBucketId(ref SessionModificationSetBucketIdOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00003F44 File Offset: 0x00002144
		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x4CBAF0", Offset = "0x4CA0F0", VA = "0x1804CBAF0")]
		public Result SetHostAddress(ref SessionModificationSetHostAddressOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00003F5C File Offset: 0x0000215C
		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x4CBBD0", Offset = "0x4CA1D0", VA = "0x1804CBBD0")]
		public Result SetInvitesAllowed(ref SessionModificationSetInvitesAllowedOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00003F74 File Offset: 0x00002174
		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x4CBCB0", Offset = "0x4CA2B0", VA = "0x1804CBCB0")]
		public Result SetJoinInProgressAllowed(ref SessionModificationSetJoinInProgressAllowedOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00003F8C File Offset: 0x0000218C
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x4CBD90", Offset = "0x4CA390", VA = "0x1804CBD90")]
		public Result SetMaxPlayers(ref SessionModificationSetMaxPlayersOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00003FA4 File Offset: 0x000021A4
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x4CBE20", Offset = "0x4CA420", VA = "0x1804CBE20")]
		public Result SetPermissionLevel(ref SessionModificationSetPermissionLevelOptions options)
		{
			return Result.Success;
		}

		// Token: 0x04000502 RID: 1282
		[Token(Token = "0x4000502")]
		public const int SessionmodificationAddattributeApiLatest = 2;

		// Token: 0x04000503 RID: 1283
		[Token(Token = "0x4000503")]
		public const int SessionmodificationMaxSessionAttributeLength = 64;

		// Token: 0x04000504 RID: 1284
		[Token(Token = "0x4000504")]
		public const int SessionmodificationMaxSessionAttributes = 64;

		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		public const int SessionmodificationMaxSessionidoverrideLength = 64;

		// Token: 0x04000506 RID: 1286
		[Token(Token = "0x4000506")]
		public const int SessionmodificationMinSessionidoverrideLength = 16;

		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		public const int SessionmodificationRemoveattributeApiLatest = 1;

		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4000508")]
		public const int SessionmodificationSetallowedplatformidsApiLatest = 1;

		// Token: 0x04000509 RID: 1289
		[Token(Token = "0x4000509")]
		public const int SessionmodificationSetbucketidApiLatest = 1;

		// Token: 0x0400050A RID: 1290
		[Token(Token = "0x400050A")]
		public const int SessionmodificationSethostaddressApiLatest = 1;

		// Token: 0x0400050B RID: 1291
		[Token(Token = "0x400050B")]
		public const int SessionmodificationSetinvitesallowedApiLatest = 1;

		// Token: 0x0400050C RID: 1292
		[Token(Token = "0x400050C")]
		public const int SessionmodificationSetjoininprogressallowedApiLatest = 1;

		// Token: 0x0400050D RID: 1293
		[Token(Token = "0x400050D")]
		public const int SessionmodificationSetmaxplayersApiLatest = 1;

		// Token: 0x0400050E RID: 1294
		[Token(Token = "0x400050E")]
		public const int SessionmodificationSetpermissionlevelApiLatest = 1;
	}
}

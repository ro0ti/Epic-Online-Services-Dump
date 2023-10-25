using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000407 RID: 1031
	[Token(Token = "0x2000407")]
	public sealed class LobbyModification : Handle
	{
		// Token: 0x06001B85 RID: 7045 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B85")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public LobbyModification()
		{
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B86")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public LobbyModification(IntPtr innerHandle)
		{
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x00007B8C File Offset: 0x00005D8C
		[Token(Token = "0x6001B87")]
		[Address(RVA = "0x52ADF0", Offset = "0x5293F0", VA = "0x18052ADF0")]
		public Result AddAttribute(ref LobbyModificationAddAttributeOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x00007BA4 File Offset: 0x00005DA4
		[Token(Token = "0x6001B88")]
		[Address(RVA = "0x52AF20", Offset = "0x529520", VA = "0x18052AF20")]
		public Result AddMemberAttribute(ref LobbyModificationAddMemberAttributeOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B89")]
		[Address(RVA = "0x52B050", Offset = "0x529650", VA = "0x18052B050")]
		public void Release()
		{
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x00007BBC File Offset: 0x00005DBC
		[Token(Token = "0x6001B8A")]
		[Address(RVA = "0x52B060", Offset = "0x529660", VA = "0x18052B060")]
		public Result RemoveAttribute(ref LobbyModificationRemoveAttributeOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x00007BD4 File Offset: 0x00005DD4
		[Token(Token = "0x6001B8B")]
		[Address(RVA = "0x52B140", Offset = "0x529740", VA = "0x18052B140")]
		public Result RemoveMemberAttribute(ref LobbyModificationRemoveMemberAttributeOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00007BEC File Offset: 0x00005DEC
		[Token(Token = "0x6001B8C")]
		[Address(RVA = "0x52B220", Offset = "0x529820", VA = "0x18052B220")]
		public Result SetAllowedPlatformIds(ref LobbyModificationSetAllowedPlatformIdsOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x00007C04 File Offset: 0x00005E04
		[Token(Token = "0x6001B8D")]
		[Address(RVA = "0x52B310", Offset = "0x529910", VA = "0x18052B310")]
		public Result SetBucketId(ref LobbyModificationSetBucketIdOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00007C1C File Offset: 0x00005E1C
		[Token(Token = "0x6001B8E")]
		[Address(RVA = "0x52B3F0", Offset = "0x5299F0", VA = "0x18052B3F0")]
		public Result SetInvitesAllowed(ref LobbyModificationSetInvitesAllowedOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x00007C34 File Offset: 0x00005E34
		[Token(Token = "0x6001B8F")]
		[Address(RVA = "0x52B4D0", Offset = "0x529AD0", VA = "0x18052B4D0")]
		public Result SetMaxMembers(ref LobbyModificationSetMaxMembersOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x00007C4C File Offset: 0x00005E4C
		[Token(Token = "0x6001B90")]
		[Address(RVA = "0x52B560", Offset = "0x529B60", VA = "0x18052B560")]
		public Result SetPermissionLevel(ref LobbyModificationSetPermissionLevelOptions options)
		{
			return Result.Success;
		}

		// Token: 0x04000C7C RID: 3196
		[Token(Token = "0x4000C7C")]
		public const int LobbymodificationAddattributeApiLatest = 2;

		// Token: 0x04000C7D RID: 3197
		[Token(Token = "0x4000C7D")]
		public const int LobbymodificationAddmemberattributeApiLatest = 2;

		// Token: 0x04000C7E RID: 3198
		[Token(Token = "0x4000C7E")]
		public const int LobbymodificationMaxAttributeLength = 64;

		// Token: 0x04000C7F RID: 3199
		[Token(Token = "0x4000C7F")]
		public const int LobbymodificationMaxAttributes = 64;

		// Token: 0x04000C80 RID: 3200
		[Token(Token = "0x4000C80")]
		public const int LobbymodificationRemoveattributeApiLatest = 1;

		// Token: 0x04000C81 RID: 3201
		[Token(Token = "0x4000C81")]
		public const int LobbymodificationRemovememberattributeApiLatest = 1;

		// Token: 0x04000C82 RID: 3202
		[Token(Token = "0x4000C82")]
		public const int LobbymodificationSetallowedplatformidsApiLatest = 1;

		// Token: 0x04000C83 RID: 3203
		[Token(Token = "0x4000C83")]
		public const int LobbymodificationSetbucketidApiLatest = 1;

		// Token: 0x04000C84 RID: 3204
		[Token(Token = "0x4000C84")]
		public const int LobbymodificationSetinvitesallowedApiLatest = 1;

		// Token: 0x04000C85 RID: 3205
		[Token(Token = "0x4000C85")]
		public const int LobbymodificationSetmaxmembersApiLatest = 1;

		// Token: 0x04000C86 RID: 3206
		[Token(Token = "0x4000C86")]
		public const int LobbymodificationSetpermissionlevelApiLatest = 1;
	}
}

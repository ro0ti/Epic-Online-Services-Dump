using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003E0 RID: 992
	[Token(Token = "0x20003E0")]
	public sealed class LobbyDetails : Handle
	{
		// Token: 0x06001A36 RID: 6710 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A36")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public LobbyDetails()
		{
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A37")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public LobbyDetails(IntPtr innerHandle)
		{
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x00007544 File Offset: 0x00005744
		[Token(Token = "0x6001A38")]
		[Address(RVA = "0x513510", Offset = "0x511B10", VA = "0x180513510")]
		public Result CopyAttributeByIndex(ref LobbyDetailsCopyAttributeByIndexOptions options, out Attribute? outAttribute)
		{
			return Result.Success;
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x0000755C File Offset: 0x0000575C
		[Token(Token = "0x6001A39")]
		[Address(RVA = "0x513600", Offset = "0x511C00", VA = "0x180513600")]
		public Result CopyAttributeByKey(ref LobbyDetailsCopyAttributeByKeyOptions options, out Attribute? outAttribute)
		{
			return Result.Success;
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x00007574 File Offset: 0x00005774
		[Token(Token = "0x6001A3A")]
		[Address(RVA = "0x513730", Offset = "0x511D30", VA = "0x180513730")]
		public Result CopyInfo(ref LobbyDetailsCopyInfoOptions options, out LobbyDetailsInfo? outLobbyDetailsInfo)
		{
			return Result.Success;
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x0000758C File Offset: 0x0000578C
		[Token(Token = "0x6001A3B")]
		[Address(RVA = "0x513810", Offset = "0x511E10", VA = "0x180513810")]
		public Result CopyMemberAttributeByIndex(ref LobbyDetailsCopyMemberAttributeByIndexOptions options, out Attribute? outAttribute)
		{
			return Result.Success;
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x000075A4 File Offset: 0x000057A4
		[Token(Token = "0x6001A3C")]
		[Address(RVA = "0x513960", Offset = "0x511F60", VA = "0x180513960")]
		public Result CopyMemberAttributeByKey(ref LobbyDetailsCopyMemberAttributeByKeyOptions options, out Attribute? outAttribute)
		{
			return Result.Success;
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x000075BC File Offset: 0x000057BC
		[Token(Token = "0x6001A3D")]
		[Address(RVA = "0x513A60", Offset = "0x512060", VA = "0x180513A60")]
		public Result CopyMemberInfo(ref LobbyDetailsCopyMemberInfoOptions options, out LobbyDetailsMemberInfo? outLobbyDetailsMemberInfo)
		{
			return Result.Success;
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x000075D4 File Offset: 0x000057D4
		[Token(Token = "0x6001A3E")]
		[Address(RVA = "0x513B90", Offset = "0x512190", VA = "0x180513B90")]
		public uint GetAttributeCount(ref LobbyDetailsGetAttributeCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6001A3F")]
		[Address(RVA = "0x513C10", Offset = "0x512210", VA = "0x180513C10")]
		public ProductUserId GetLobbyOwner(ref LobbyDetailsGetLobbyOwnerOptions options)
		{
			return null;
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x000075EC File Offset: 0x000057EC
		[Token(Token = "0x6001A40")]
		[Address(RVA = "0x513CC0", Offset = "0x5122C0", VA = "0x180513CC0")]
		public uint GetMemberAttributeCount(ref LobbyDetailsGetMemberAttributeCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6001A41")]
		[Address(RVA = "0x513DA0", Offset = "0x5123A0", VA = "0x180513DA0")]
		public ProductUserId GetMemberByIndex(ref LobbyDetailsGetMemberByIndexOptions options)
		{
			return null;
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x00007604 File Offset: 0x00005804
		[Token(Token = "0x6001A42")]
		[Address(RVA = "0x513E60", Offset = "0x512460", VA = "0x180513E60")]
		public uint GetMemberCount(ref LobbyDetailsGetMemberCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A43")]
		[Address(RVA = "0x513EE0", Offset = "0x5124E0", VA = "0x180513EE0")]
		public void Release()
		{
		}

		// Token: 0x04000BCF RID: 3023
		[Token(Token = "0x4000BCF")]
		public const int LobbydetailsCopyattributebyindexApiLatest = 1;

		// Token: 0x04000BD0 RID: 3024
		[Token(Token = "0x4000BD0")]
		public const int LobbydetailsCopyattributebykeyApiLatest = 1;

		// Token: 0x04000BD1 RID: 3025
		[Token(Token = "0x4000BD1")]
		public const int LobbydetailsCopyinfoApiLatest = 1;

		// Token: 0x04000BD2 RID: 3026
		[Token(Token = "0x4000BD2")]
		public const int LobbydetailsCopymemberattributebyindexApiLatest = 1;

		// Token: 0x04000BD3 RID: 3027
		[Token(Token = "0x4000BD3")]
		public const int LobbydetailsCopymemberattributebykeyApiLatest = 1;

		// Token: 0x04000BD4 RID: 3028
		[Token(Token = "0x4000BD4")]
		public const int LobbydetailsCopymemberinfoApiLatest = 1;

		// Token: 0x04000BD5 RID: 3029
		[Token(Token = "0x4000BD5")]
		public const int LobbydetailsGetattributecountApiLatest = 1;

		// Token: 0x04000BD6 RID: 3030
		[Token(Token = "0x4000BD6")]
		public const int LobbydetailsGetlobbyownerApiLatest = 1;

		// Token: 0x04000BD7 RID: 3031
		[Token(Token = "0x4000BD7")]
		public const int LobbydetailsGetmemberattributecountApiLatest = 1;

		// Token: 0x04000BD8 RID: 3032
		[Token(Token = "0x4000BD8")]
		public const int LobbydetailsGetmemberbyindexApiLatest = 1;

		// Token: 0x04000BD9 RID: 3033
		[Token(Token = "0x4000BD9")]
		public const int LobbydetailsGetmembercountApiLatest = 1;

		// Token: 0x04000BDA RID: 3034
		[Token(Token = "0x4000BDA")]
		public const int LobbydetailsInfoApiLatest = 3;

		// Token: 0x04000BDB RID: 3035
		[Token(Token = "0x4000BDB")]
		public const int LobbydetailsMemberinfoApiLatest = 1;
	}
}

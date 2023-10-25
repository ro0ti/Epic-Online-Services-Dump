using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Friends
{
	// Token: 0x020004FE RID: 1278
	[Token(Token = "0x20004FE")]
	public sealed class FriendsInterface : Handle
	{
		// Token: 0x060020C2 RID: 8386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020C2")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public FriendsInterface()
		{
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020C3")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public FriendsInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020C4")]
		[Address(RVA = "0x545260", Offset = "0x543860", VA = "0x180545260")]
		public void AcceptInvite(ref AcceptInviteOptions options, object clientData, OnAcceptInviteCallback completionDelegate)
		{
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x00008C84 File Offset: 0x00006E84
		[Token(Token = "0x60020C5")]
		[Address(RVA = "0x545430", Offset = "0x543A30", VA = "0x180545430")]
		public ulong AddNotifyBlockedUsersUpdate(ref AddNotifyBlockedUsersUpdateOptions options, object clientData, OnBlockedUsersUpdateCallback blockedUsersUpdateHandler)
		{
			return 0UL;
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x00008C9C File Offset: 0x00006E9C
		[Token(Token = "0x60020C6")]
		[Address(RVA = "0x5455F0", Offset = "0x543BF0", VA = "0x1805455F0")]
		public ulong AddNotifyFriendsUpdate(ref AddNotifyFriendsUpdateOptions options, object clientData, OnFriendsUpdateCallback friendsUpdateHandler)
		{
			return 0UL;
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x60020C7")]
		[Address(RVA = "0x5457B0", Offset = "0x543DB0", VA = "0x1805457B0")]
		public EpicAccountId GetBlockedUserAtIndex(ref GetBlockedUserAtIndexOptions options)
		{
			return null;
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x00008CB4 File Offset: 0x00006EB4
		[Token(Token = "0x60020C8")]
		[Address(RVA = "0x5458D0", Offset = "0x543ED0", VA = "0x1805458D0")]
		public int GetBlockedUsersCount(ref GetBlockedUsersCountOptions options)
		{
			return 0;
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x60020C9")]
		[Address(RVA = "0x5459B0", Offset = "0x543FB0", VA = "0x1805459B0")]
		public EpicAccountId GetFriendAtIndex(ref GetFriendAtIndexOptions options)
		{
			return null;
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x00008CCC File Offset: 0x00006ECC
		[Token(Token = "0x60020CA")]
		[Address(RVA = "0x545AD0", Offset = "0x5440D0", VA = "0x180545AD0")]
		public int GetFriendsCount(ref GetFriendsCountOptions options)
		{
			return 0;
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x00008CE4 File Offset: 0x00006EE4
		[Token(Token = "0x60020CB")]
		[Address(RVA = "0x545BB0", Offset = "0x5441B0", VA = "0x180545BB0")]
		public FriendsStatus GetStatus(ref GetStatusOptions options)
		{
			return FriendsStatus.NotFriends;
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020CC")]
		[Address(RVA = "0x546010", Offset = "0x544610", VA = "0x180546010")]
		public void QueryFriends(ref QueryFriendsOptions options, object clientData, OnQueryFriendsCallback completionDelegate)
		{
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020CD")]
		[Address(RVA = "0x546210", Offset = "0x544810", VA = "0x180546210")]
		public void RejectInvite(ref RejectInviteOptions options, object clientData, OnRejectInviteCallback completionDelegate)
		{
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020CE")]
		[Address(RVA = "0x5463E0", Offset = "0x5449E0", VA = "0x1805463E0")]
		public void RemoveNotifyBlockedUsersUpdate(ulong notificationId)
		{
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020CF")]
		[Address(RVA = "0x546450", Offset = "0x544A50", VA = "0x180546450")]
		public void RemoveNotifyFriendsUpdate(ulong notificationId)
		{
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020D0")]
		[Address(RVA = "0x5464C0", Offset = "0x544AC0", VA = "0x1805464C0")]
		public void SendInvite(ref SendInviteOptions options, object clientData, OnSendInviteCallback completionDelegate)
		{
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020D1")]
		[Address(RVA = "0x545C50", Offset = "0x544250", VA = "0x180545C50")]
		[MonoPInvokeCallback(typeof(OnAcceptInviteCallbackInternal))]
		internal static void OnAcceptInviteCallbackInternalImplementation(ref AcceptInviteCallbackInfoInternal data)
		{
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020D2")]
		[Address(RVA = "0x545CF0", Offset = "0x5442F0", VA = "0x180545CF0")]
		[MonoPInvokeCallback(typeof(OnBlockedUsersUpdateCallbackInternal))]
		internal static void OnBlockedUsersUpdateCallbackInternalImplementation(ref OnBlockedUsersUpdateInfoInternal data)
		{
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020D3")]
		[Address(RVA = "0x545D90", Offset = "0x544390", VA = "0x180545D90")]
		[MonoPInvokeCallback(typeof(OnFriendsUpdateCallbackInternal))]
		internal static void OnFriendsUpdateCallbackInternalImplementation(ref OnFriendsUpdateInfoInternal data)
		{
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020D4")]
		[Address(RVA = "0x545E30", Offset = "0x544430", VA = "0x180545E30")]
		[MonoPInvokeCallback(typeof(OnQueryFriendsCallbackInternal))]
		internal static void OnQueryFriendsCallbackInternalImplementation(ref QueryFriendsCallbackInfoInternal data)
		{
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020D5")]
		[Address(RVA = "0x545ED0", Offset = "0x5444D0", VA = "0x180545ED0")]
		[MonoPInvokeCallback(typeof(OnRejectInviteCallbackInternal))]
		internal static void OnRejectInviteCallbackInternalImplementation(ref RejectInviteCallbackInfoInternal data)
		{
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020D6")]
		[Address(RVA = "0x545F70", Offset = "0x544570", VA = "0x180545F70")]
		[MonoPInvokeCallback(typeof(OnSendInviteCallbackInternal))]
		internal static void OnSendInviteCallbackInternalImplementation(ref SendInviteCallbackInfoInternal data)
		{
		}

		// Token: 0x04000E78 RID: 3704
		[Token(Token = "0x4000E78")]
		public const int AcceptinviteApiLatest = 1;

		// Token: 0x04000E79 RID: 3705
		[Token(Token = "0x4000E79")]
		public const int AddnotifyblockedusersupdateApiLatest = 1;

		// Token: 0x04000E7A RID: 3706
		[Token(Token = "0x4000E7A")]
		public const int AddnotifyfriendsupdateApiLatest = 1;

		// Token: 0x04000E7B RID: 3707
		[Token(Token = "0x4000E7B")]
		public const int GetblockeduseratindexApiLatest = 1;

		// Token: 0x04000E7C RID: 3708
		[Token(Token = "0x4000E7C")]
		public const int GetblockeduserscountApiLatest = 1;

		// Token: 0x04000E7D RID: 3709
		[Token(Token = "0x4000E7D")]
		public const int GetfriendatindexApiLatest = 1;

		// Token: 0x04000E7E RID: 3710
		[Token(Token = "0x4000E7E")]
		public const int GetfriendscountApiLatest = 1;

		// Token: 0x04000E7F RID: 3711
		[Token(Token = "0x4000E7F")]
		public const int GetstatusApiLatest = 1;

		// Token: 0x04000E80 RID: 3712
		[Token(Token = "0x4000E80")]
		public const int QueryfriendsApiLatest = 1;

		// Token: 0x04000E81 RID: 3713
		[Token(Token = "0x4000E81")]
		public const int RejectinviteApiLatest = 1;

		// Token: 0x04000E82 RID: 3714
		[Token(Token = "0x4000E82")]
		public const int SendinviteApiLatest = 1;
	}
}

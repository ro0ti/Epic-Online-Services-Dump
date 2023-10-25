using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003FB RID: 1019
	[Token(Token = "0x20003FB")]
	public sealed class LobbyInterface : Handle
	{
		// Token: 0x06001ACA RID: 6858 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001ACA")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public LobbyInterface()
		{
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001ACB")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public LobbyInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x00007874 File Offset: 0x00005A74
		[Token(Token = "0x6001ACC")]
		[Address(RVA = "0x513EF0", Offset = "0x5124F0", VA = "0x180513EF0")]
		public ulong AddNotifyJoinLobbyAccepted(ref AddNotifyJoinLobbyAcceptedOptions options, object clientData, OnJoinLobbyAcceptedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x0000788C File Offset: 0x00005A8C
		[Token(Token = "0x6001ACD")]
		[Address(RVA = "0x514030", Offset = "0x512630", VA = "0x180514030")]
		public ulong AddNotifyLeaveLobbyRequested(ref AddNotifyLeaveLobbyRequestedOptions options, object clientData, OnLeaveLobbyRequestedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x000078A4 File Offset: 0x00005AA4
		[Token(Token = "0x6001ACE")]
		[Address(RVA = "0x514170", Offset = "0x512770", VA = "0x180514170")]
		public ulong AddNotifyLobbyInviteAccepted(ref AddNotifyLobbyInviteAcceptedOptions options, object clientData, OnLobbyInviteAcceptedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x000078BC File Offset: 0x00005ABC
		[Token(Token = "0x6001ACF")]
		[Address(RVA = "0x5142B0", Offset = "0x5128B0", VA = "0x1805142B0")]
		public ulong AddNotifyLobbyInviteReceived(ref AddNotifyLobbyInviteReceivedOptions options, object clientData, OnLobbyInviteReceivedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x000078D4 File Offset: 0x00005AD4
		[Token(Token = "0x6001AD0")]
		[Address(RVA = "0x5143F0", Offset = "0x5129F0", VA = "0x1805143F0")]
		public ulong AddNotifyLobbyInviteRejected(ref AddNotifyLobbyInviteRejectedOptions options, object clientData, OnLobbyInviteRejectedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x000078EC File Offset: 0x00005AEC
		[Token(Token = "0x6001AD1")]
		[Address(RVA = "0x514530", Offset = "0x512B30", VA = "0x180514530")]
		public ulong AddNotifyLobbyMemberStatusReceived(ref AddNotifyLobbyMemberStatusReceivedOptions options, object clientData, OnLobbyMemberStatusReceivedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00007904 File Offset: 0x00005B04
		[Token(Token = "0x6001AD2")]
		[Address(RVA = "0x514670", Offset = "0x512C70", VA = "0x180514670")]
		public ulong AddNotifyLobbyMemberUpdateReceived(ref AddNotifyLobbyMemberUpdateReceivedOptions options, object clientData, OnLobbyMemberUpdateReceivedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x0000791C File Offset: 0x00005B1C
		[Token(Token = "0x6001AD3")]
		[Address(RVA = "0x5147B0", Offset = "0x512DB0", VA = "0x1805147B0")]
		public ulong AddNotifyLobbyUpdateReceived(ref AddNotifyLobbyUpdateReceivedOptions options, object clientData, OnLobbyUpdateReceivedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00007934 File Offset: 0x00005B34
		[Token(Token = "0x6001AD4")]
		[Address(RVA = "0x5148F0", Offset = "0x512EF0", VA = "0x1805148F0")]
		public ulong AddNotifyRTCRoomConnectionChanged(ref AddNotifyRTCRoomConnectionChangedOptions options, object clientData, OnRTCRoomConnectionChangedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x0000794C File Offset: 0x00005B4C
		[Token(Token = "0x6001AD5")]
		[Address(RVA = "0x514A50", Offset = "0x513050", VA = "0x180514A50")]
		public ulong AddNotifySendLobbyNativeInviteRequested(ref AddNotifySendLobbyNativeInviteRequestedOptions options, object clientData, OnSendLobbyNativeInviteRequestedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x00007964 File Offset: 0x00005B64
		[Token(Token = "0x6001AD6")]
		[Address(RVA = "0x514D70", Offset = "0x513370", VA = "0x180514D70")]
		public Result CopyLobbyDetailsHandle(ref CopyLobbyDetailsHandleOptions options, out LobbyDetails outLobbyDetailsHandle)
		{
			return Result.Success;
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x0000797C File Offset: 0x00005B7C
		[Token(Token = "0x6001AD7")]
		[Address(RVA = "0x514B90", Offset = "0x513190", VA = "0x180514B90")]
		public Result CopyLobbyDetailsHandleByInviteId(ref CopyLobbyDetailsHandleByInviteIdOptions options, out LobbyDetails outLobbyDetailsHandle)
		{
			return Result.Success;
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x00007994 File Offset: 0x00005B94
		[Token(Token = "0x6001AD8")]
		[Address(RVA = "0x514CA0", Offset = "0x5132A0", VA = "0x180514CA0")]
		public Result CopyLobbyDetailsHandleByUiEventId(ref CopyLobbyDetailsHandleByUiEventIdOptions options, out LobbyDetails outLobbyDetailsHandle)
		{
			return Result.Success;
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AD9")]
		[Address(RVA = "0x514F20", Offset = "0x513520", VA = "0x180514F20")]
		public void CreateLobby(ref CreateLobbyOptions options, object clientData, OnCreateLobbyCallback completionDelegate)
		{
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x000079AC File Offset: 0x00005BAC
		[Token(Token = "0x6001ADA")]
		[Address(RVA = "0x514E50", Offset = "0x513450", VA = "0x180514E50")]
		public Result CreateLobbySearch(ref CreateLobbySearchOptions options, out LobbySearch outLobbySearchHandle)
		{
			return Result.Success;
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001ADB")]
		[Address(RVA = "0x515090", Offset = "0x513690", VA = "0x180515090")]
		public void DestroyLobby(ref DestroyLobbyOptions options, object clientData, OnDestroyLobbyCallback completionDelegate)
		{
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x000079C4 File Offset: 0x00005BC4
		[Token(Token = "0x6001ADC")]
		[Address(RVA = "0x5151D0", Offset = "0x5137D0", VA = "0x1805151D0")]
		public Result GetConnectString(ref GetConnectStringOptions options, out Utf8String outBuffer)
		{
			return Result.Success;
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x000079DC File Offset: 0x00005BDC
		[Token(Token = "0x6001ADD")]
		[Address(RVA = "0x5152C0", Offset = "0x5138C0", VA = "0x1805152C0")]
		public uint GetInviteCount(ref GetInviteCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x000079F4 File Offset: 0x00005BF4
		[Token(Token = "0x6001ADE")]
		[Address(RVA = "0x5153A0", Offset = "0x5139A0", VA = "0x1805153A0")]
		public Result GetInviteIdByIndex(ref GetInviteIdByIndexOptions options, out Utf8String outBuffer)
		{
			return Result.Success;
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x00007A0C File Offset: 0x00005C0C
		[Token(Token = "0x6001ADF")]
		[Address(RVA = "0x5154D0", Offset = "0x513AD0", VA = "0x1805154D0")]
		public Result GetRTCRoomName(ref GetRTCRoomNameOptions options, out Utf8String outBuffer)
		{
			return Result.Success;
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AE0")]
		[Address(RVA = "0x5155C0", Offset = "0x513BC0", VA = "0x1805155C0")]
		public void HardMuteMember(ref HardMuteMemberOptions options, object clientData, OnHardMuteMemberCallback completionDelegate)
		{
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00007A24 File Offset: 0x00005C24
		[Token(Token = "0x6001AE1")]
		[Address(RVA = "0x515710", Offset = "0x513D10", VA = "0x180515710")]
		public Result IsRTCRoomConnected(ref IsRTCRoomConnectedOptions options, out bool bOutIsConnected)
		{
			return Result.Success;
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AE2")]
		[Address(RVA = "0x515930", Offset = "0x513F30", VA = "0x180515930")]
		public void JoinLobby(ref JoinLobbyOptions options, object clientData, OnJoinLobbyCallback completionDelegate)
		{
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AE3")]
		[Address(RVA = "0x5157E0", Offset = "0x513DE0", VA = "0x1805157E0")]
		public void JoinLobbyById(ref JoinLobbyByIdOptions options, object clientData, OnJoinLobbyByIdCallback completionDelegate)
		{
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AE4")]
		[Address(RVA = "0x515A80", Offset = "0x514080", VA = "0x180515A80")]
		public void KickMember(ref KickMemberOptions options, object clientData, OnKickMemberCallback completionDelegate)
		{
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AE5")]
		[Address(RVA = "0x515BC0", Offset = "0x5141C0", VA = "0x180515BC0")]
		public void LeaveLobby(ref LeaveLobbyOptions options, object clientData, OnLeaveLobbyCallback completionDelegate)
		{
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x00007A3C File Offset: 0x00005C3C
		[Token(Token = "0x6001AE6")]
		[Address(RVA = "0x516AF0", Offset = "0x5150F0", VA = "0x180516AF0")]
		public Result ParseConnectString(ref ParseConnectStringOptions options, out Utf8String outBuffer)
		{
			return Result.Success;
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AE7")]
		[Address(RVA = "0x516BE0", Offset = "0x5151E0", VA = "0x180516BE0")]
		public void PromoteMember(ref PromoteMemberOptions options, object clientData, OnPromoteMemberCallback completionDelegate)
		{
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AE8")]
		[Address(RVA = "0x516D20", Offset = "0x515320", VA = "0x180516D20")]
		public void QueryInvites(ref QueryInvitesOptions options, object clientData, OnQueryInvitesCallback completionDelegate)
		{
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AE9")]
		[Address(RVA = "0x516E60", Offset = "0x515460", VA = "0x180516E60")]
		public void RejectInvite(ref RejectInviteOptions options, object clientData, OnRejectInviteCallback completionDelegate)
		{
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AEA")]
		[Address(RVA = "0x516FA0", Offset = "0x5155A0", VA = "0x180516FA0")]
		public void RemoveNotifyJoinLobbyAccepted(ulong inId)
		{
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AEB")]
		[Address(RVA = "0x517010", Offset = "0x515610", VA = "0x180517010")]
		public void RemoveNotifyLeaveLobbyRequested(ulong inId)
		{
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AEC")]
		[Address(RVA = "0x517080", Offset = "0x515680", VA = "0x180517080")]
		public void RemoveNotifyLobbyInviteAccepted(ulong inId)
		{
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AED")]
		[Address(RVA = "0x5170F0", Offset = "0x5156F0", VA = "0x1805170F0")]
		public void RemoveNotifyLobbyInviteReceived(ulong inId)
		{
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AEE")]
		[Address(RVA = "0x517160", Offset = "0x515760", VA = "0x180517160")]
		public void RemoveNotifyLobbyInviteRejected(ulong inId)
		{
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AEF")]
		[Address(RVA = "0x5171D0", Offset = "0x5157D0", VA = "0x1805171D0")]
		public void RemoveNotifyLobbyMemberStatusReceived(ulong inId)
		{
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AF0")]
		[Address(RVA = "0x517240", Offset = "0x515840", VA = "0x180517240")]
		public void RemoveNotifyLobbyMemberUpdateReceived(ulong inId)
		{
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AF1")]
		[Address(RVA = "0x5172B0", Offset = "0x5158B0", VA = "0x1805172B0")]
		public void RemoveNotifyLobbyUpdateReceived(ulong inId)
		{
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AF2")]
		[Address(RVA = "0x517320", Offset = "0x515920", VA = "0x180517320")]
		public void RemoveNotifyRTCRoomConnectionChanged(ulong inId)
		{
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AF3")]
		[Address(RVA = "0x517390", Offset = "0x515990", VA = "0x180517390")]
		public void RemoveNotifySendLobbyNativeInviteRequested(ulong inId)
		{
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AF4")]
		[Address(RVA = "0x517400", Offset = "0x515A00", VA = "0x180517400")]
		public void SendInvite(ref SendInviteOptions options, object clientData, OnSendInviteCallback completionDelegate)
		{
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AF5")]
		[Address(RVA = "0x517620", Offset = "0x515C20", VA = "0x180517620")]
		public void UpdateLobby(ref UpdateLobbyOptions options, object clientData, OnUpdateLobbyCallback completionDelegate)
		{
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00007A54 File Offset: 0x00005C54
		[Token(Token = "0x6001AF6")]
		[Address(RVA = "0x517540", Offset = "0x515B40", VA = "0x180517540")]
		public Result UpdateLobbyModification(ref UpdateLobbyModificationOptions options, out LobbyModification outLobbyModificationHandle)
		{
			return Result.Success;
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AF7")]
		[Address(RVA = "0x515D00", Offset = "0x514300", VA = "0x180515D00")]
		[MonoPInvokeCallback(typeof(OnCreateLobbyCallbackInternal))]
		internal static void OnCreateLobbyCallbackInternalImplementation(ref CreateLobbyCallbackInfoInternal data)
		{
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AF8")]
		[Address(RVA = "0x515DA0", Offset = "0x5143A0", VA = "0x180515DA0")]
		[MonoPInvokeCallback(typeof(OnDestroyLobbyCallbackInternal))]
		internal static void OnDestroyLobbyCallbackInternalImplementation(ref DestroyLobbyCallbackInfoInternal data)
		{
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AF9")]
		[Address(RVA = "0x515E40", Offset = "0x514440", VA = "0x180515E40")]
		[MonoPInvokeCallback(typeof(OnHardMuteMemberCallbackInternal))]
		internal static void OnHardMuteMemberCallbackInternalImplementation(ref HardMuteMemberCallbackInfoInternal data)
		{
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AFA")]
		[Address(RVA = "0x515EE0", Offset = "0x5144E0", VA = "0x180515EE0")]
		[MonoPInvokeCallback(typeof(OnJoinLobbyAcceptedCallbackInternal))]
		internal static void OnJoinLobbyAcceptedCallbackInternalImplementation(ref JoinLobbyAcceptedCallbackInfoInternal data)
		{
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AFB")]
		[Address(RVA = "0x515F80", Offset = "0x514580", VA = "0x180515F80")]
		[MonoPInvokeCallback(typeof(OnJoinLobbyByIdCallbackInternal))]
		internal static void OnJoinLobbyByIdCallbackInternalImplementation(ref JoinLobbyByIdCallbackInfoInternal data)
		{
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AFC")]
		[Address(RVA = "0x516020", Offset = "0x514620", VA = "0x180516020")]
		[MonoPInvokeCallback(typeof(OnJoinLobbyCallbackInternal))]
		internal static void OnJoinLobbyCallbackInternalImplementation(ref JoinLobbyCallbackInfoInternal data)
		{
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AFD")]
		[Address(RVA = "0x5160C0", Offset = "0x5146C0", VA = "0x1805160C0")]
		[MonoPInvokeCallback(typeof(OnKickMemberCallbackInternal))]
		internal static void OnKickMemberCallbackInternalImplementation(ref KickMemberCallbackInfoInternal data)
		{
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AFE")]
		[Address(RVA = "0x516160", Offset = "0x514760", VA = "0x180516160")]
		[MonoPInvokeCallback(typeof(OnLeaveLobbyCallbackInternal))]
		internal static void OnLeaveLobbyCallbackInternalImplementation(ref LeaveLobbyCallbackInfoInternal data)
		{
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AFF")]
		[Address(RVA = "0x516200", Offset = "0x514800", VA = "0x180516200")]
		[MonoPInvokeCallback(typeof(OnLeaveLobbyRequestedCallbackInternal))]
		internal static void OnLeaveLobbyRequestedCallbackInternalImplementation(ref LeaveLobbyRequestedCallbackInfoInternal data)
		{
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B00")]
		[Address(RVA = "0x5162A0", Offset = "0x5148A0", VA = "0x1805162A0")]
		[MonoPInvokeCallback(typeof(OnLobbyInviteAcceptedCallbackInternal))]
		internal static void OnLobbyInviteAcceptedCallbackInternalImplementation(ref LobbyInviteAcceptedCallbackInfoInternal data)
		{
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B01")]
		[Address(RVA = "0x516350", Offset = "0x514950", VA = "0x180516350")]
		[MonoPInvokeCallback(typeof(OnLobbyInviteReceivedCallbackInternal))]
		internal static void OnLobbyInviteReceivedCallbackInternalImplementation(ref LobbyInviteReceivedCallbackInfoInternal data)
		{
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B02")]
		[Address(RVA = "0x5163F0", Offset = "0x5149F0", VA = "0x1805163F0")]
		[MonoPInvokeCallback(typeof(OnLobbyInviteRejectedCallbackInternal))]
		internal static void OnLobbyInviteRejectedCallbackInternalImplementation(ref LobbyInviteRejectedCallbackInfoInternal data)
		{
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B03")]
		[Address(RVA = "0x5164A0", Offset = "0x514AA0", VA = "0x1805164A0")]
		[MonoPInvokeCallback(typeof(OnLobbyMemberStatusReceivedCallbackInternal))]
		internal static void OnLobbyMemberStatusReceivedCallbackInternalImplementation(ref LobbyMemberStatusReceivedCallbackInfoInternal data)
		{
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B04")]
		[Address(RVA = "0x516540", Offset = "0x514B40", VA = "0x180516540")]
		[MonoPInvokeCallback(typeof(OnLobbyMemberUpdateReceivedCallbackInternal))]
		internal static void OnLobbyMemberUpdateReceivedCallbackInternalImplementation(ref LobbyMemberUpdateReceivedCallbackInfoInternal data)
		{
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B05")]
		[Address(RVA = "0x5165E0", Offset = "0x514BE0", VA = "0x1805165E0")]
		[MonoPInvokeCallback(typeof(OnLobbyUpdateReceivedCallbackInternal))]
		internal static void OnLobbyUpdateReceivedCallbackInternalImplementation(ref LobbyUpdateReceivedCallbackInfoInternal data)
		{
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B06")]
		[Address(RVA = "0x516680", Offset = "0x514C80", VA = "0x180516680")]
		[MonoPInvokeCallback(typeof(OnPromoteMemberCallbackInternal))]
		internal static void OnPromoteMemberCallbackInternalImplementation(ref PromoteMemberCallbackInfoInternal data)
		{
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B07")]
		[Address(RVA = "0x516720", Offset = "0x514D20", VA = "0x180516720")]
		[MonoPInvokeCallback(typeof(OnQueryInvitesCallbackInternal))]
		internal static void OnQueryInvitesCallbackInternalImplementation(ref QueryInvitesCallbackInfoInternal data)
		{
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B08")]
		[Address(RVA = "0x5167C0", Offset = "0x514DC0", VA = "0x1805167C0")]
		[MonoPInvokeCallback(typeof(OnRTCRoomConnectionChangedCallbackInternal))]
		internal static void OnRTCRoomConnectionChangedCallbackInternalImplementation(ref RTCRoomConnectionChangedCallbackInfoInternal data)
		{
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B09")]
		[Address(RVA = "0x516860", Offset = "0x514E60", VA = "0x180516860")]
		[MonoPInvokeCallback(typeof(OnRejectInviteCallbackInternal))]
		internal static void OnRejectInviteCallbackInternalImplementation(ref RejectInviteCallbackInfoInternal data)
		{
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B0A")]
		[Address(RVA = "0x516900", Offset = "0x514F00", VA = "0x180516900")]
		[MonoPInvokeCallback(typeof(OnSendInviteCallbackInternal))]
		internal static void OnSendInviteCallbackInternalImplementation(ref SendInviteCallbackInfoInternal data)
		{
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B0B")]
		[Address(RVA = "0x5169A0", Offset = "0x514FA0", VA = "0x1805169A0")]
		[MonoPInvokeCallback(typeof(OnSendLobbyNativeInviteRequestedCallbackInternal))]
		internal static void OnSendLobbyNativeInviteRequestedCallbackInternalImplementation(ref SendLobbyNativeInviteRequestedCallbackInfoInternal data)
		{
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B0C")]
		[Address(RVA = "0x516A50", Offset = "0x515050", VA = "0x180516A50")]
		[MonoPInvokeCallback(typeof(OnUpdateLobbyCallbackInternal))]
		internal static void OnUpdateLobbyCallbackInternalImplementation(ref UpdateLobbyCallbackInfoInternal data)
		{
		}

		// Token: 0x04000C1C RID: 3100
		[Token(Token = "0x4000C1C")]
		public const int AddnotifyjoinlobbyacceptedApiLatest = 1;

		// Token: 0x04000C1D RID: 3101
		[Token(Token = "0x4000C1D")]
		public const int AddnotifyleavelobbyrequestedApiLatest = 1;

		// Token: 0x04000C1E RID: 3102
		[Token(Token = "0x4000C1E")]
		public const int AddnotifylobbyinviteacceptedApiLatest = 1;

		// Token: 0x04000C1F RID: 3103
		[Token(Token = "0x4000C1F")]
		public const int AddnotifylobbyinvitereceivedApiLatest = 1;

		// Token: 0x04000C20 RID: 3104
		[Token(Token = "0x4000C20")]
		public const int AddnotifylobbyinviterejectedApiLatest = 1;

		// Token: 0x04000C21 RID: 3105
		[Token(Token = "0x4000C21")]
		public const int AddnotifylobbymemberstatusreceivedApiLatest = 1;

		// Token: 0x04000C22 RID: 3106
		[Token(Token = "0x4000C22")]
		public const int AddnotifylobbymemberupdatereceivedApiLatest = 1;

		// Token: 0x04000C23 RID: 3107
		[Token(Token = "0x4000C23")]
		public const int AddnotifylobbyupdatereceivedApiLatest = 1;

		// Token: 0x04000C24 RID: 3108
		[Token(Token = "0x4000C24")]
		public const int AddnotifyrtcroomconnectionchangedApiLatest = 2;

		// Token: 0x04000C25 RID: 3109
		[Token(Token = "0x4000C25")]
		public const int AddnotifysendlobbynativeinviterequestedApiLatest = 1;

		// Token: 0x04000C26 RID: 3110
		[Token(Token = "0x4000C26")]
		public const int AttributeApiLatest = 1;

		// Token: 0x04000C27 RID: 3111
		[Token(Token = "0x4000C27")]
		public const int AttributedataApiLatest = 1;

		// Token: 0x04000C28 RID: 3112
		[Token(Token = "0x4000C28")]
		public const int CopylobbydetailshandleApiLatest = 1;

		// Token: 0x04000C29 RID: 3113
		[Token(Token = "0x4000C29")]
		public const int CopylobbydetailshandlebyinviteidApiLatest = 1;

		// Token: 0x04000C2A RID: 3114
		[Token(Token = "0x4000C2A")]
		public const int CopylobbydetailshandlebyuieventidApiLatest = 1;

		// Token: 0x04000C2B RID: 3115
		[Token(Token = "0x4000C2B")]
		public const int CreatelobbyApiLatest = 9;

		// Token: 0x04000C2C RID: 3116
		[Token(Token = "0x4000C2C")]
		public const int CreatelobbysearchApiLatest = 1;

		// Token: 0x04000C2D RID: 3117
		[Token(Token = "0x4000C2D")]
		public const int DestroylobbyApiLatest = 1;

		// Token: 0x04000C2E RID: 3118
		[Token(Token = "0x4000C2E")]
		public const int GetconnectstringApiLatest = 1;

		// Token: 0x04000C2F RID: 3119
		[Token(Token = "0x4000C2F")]
		public const int GetconnectstringBufferSize = 256;

		// Token: 0x04000C30 RID: 3120
		[Token(Token = "0x4000C30")]
		public const int GetinvitecountApiLatest = 1;

		// Token: 0x04000C31 RID: 3121
		[Token(Token = "0x4000C31")]
		public const int GetinviteidbyindexApiLatest = 1;

		// Token: 0x04000C32 RID: 3122
		[Token(Token = "0x4000C32")]
		public const int GetrtcroomnameApiLatest = 1;

		// Token: 0x04000C33 RID: 3123
		[Token(Token = "0x4000C33")]
		public const int HardmutememberApiLatest = 1;

		// Token: 0x04000C34 RID: 3124
		[Token(Token = "0x4000C34")]
		public const int InviteidMaxLength = 64;

		// Token: 0x04000C35 RID: 3125
		[Token(Token = "0x4000C35")]
		public const int IsrtcroomconnectedApiLatest = 1;

		// Token: 0x04000C36 RID: 3126
		[Token(Token = "0x4000C36")]
		public const int JoinlobbyApiLatest = 4;

		// Token: 0x04000C37 RID: 3127
		[Token(Token = "0x4000C37")]
		public const int JoinlobbybyidApiLatest = 2;

		// Token: 0x04000C38 RID: 3128
		[Token(Token = "0x4000C38")]
		public const int KickmemberApiLatest = 1;

		// Token: 0x04000C39 RID: 3129
		[Token(Token = "0x4000C39")]
		public const int LeavelobbyApiLatest = 1;

		// Token: 0x04000C3A RID: 3130
		[Token(Token = "0x4000C3A")]
		public const int LocalrtcoptionsApiLatest = 1;

		// Token: 0x04000C3B RID: 3131
		[Token(Token = "0x4000C3B")]
		public const int MaxLobbies = 16;

		// Token: 0x04000C3C RID: 3132
		[Token(Token = "0x4000C3C")]
		public const int MaxLobbyMembers = 64;

		// Token: 0x04000C3D RID: 3133
		[Token(Token = "0x4000C3D")]
		public const int MaxLobbyidoverrideLength = 60;

		// Token: 0x04000C3E RID: 3134
		[Token(Token = "0x4000C3E")]
		public const int MaxSearchResults = 200;

		// Token: 0x04000C3F RID: 3135
		[Token(Token = "0x4000C3F")]
		public const int MinLobbyidoverrideLength = 4;

		// Token: 0x04000C40 RID: 3136
		[Token(Token = "0x4000C40")]
		public const int ParseconnectstringApiLatest = 1;

		// Token: 0x04000C41 RID: 3137
		[Token(Token = "0x4000C41")]
		public const int ParseconnectstringBufferSize = 256;

		// Token: 0x04000C42 RID: 3138
		[Token(Token = "0x4000C42")]
		public const int PromotememberApiLatest = 1;

		// Token: 0x04000C43 RID: 3139
		[Token(Token = "0x4000C43")]
		public const int QueryinvitesApiLatest = 1;

		// Token: 0x04000C44 RID: 3140
		[Token(Token = "0x4000C44")]
		public const int RejectinviteApiLatest = 1;

		// Token: 0x04000C45 RID: 3141
		[Token(Token = "0x4000C45")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Utf8String SearchBucketId;

		// Token: 0x04000C46 RID: 3142
		[Token(Token = "0x4000C46")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Utf8String SearchMincurrentmembers;

		// Token: 0x04000C47 RID: 3143
		[Token(Token = "0x4000C47")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Utf8String SearchMinslotsavailable;

		// Token: 0x04000C48 RID: 3144
		[Token(Token = "0x4000C48")]
		public const int SendinviteApiLatest = 1;

		// Token: 0x04000C49 RID: 3145
		[Token(Token = "0x4000C49")]
		public const int UpdatelobbyApiLatest = 1;

		// Token: 0x04000C4A RID: 3146
		[Token(Token = "0x4000C4A")]
		public const int UpdatelobbymodificationApiLatest = 1;
	}
}

using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000194 RID: 404
	[Token(Token = "0x2000194")]
	public sealed class SessionsInterface : Handle
	{
		// Token: 0x06000B84 RID: 2948 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public SessionsInterface()
		{
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public SessionsInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x000041CC File Offset: 0x000023CC
		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x4CD630", Offset = "0x4CBC30", VA = "0x1804CD630")]
		public ulong AddNotifyJoinSessionAccepted(ref AddNotifyJoinSessionAcceptedOptions options, object clientData, OnJoinSessionAcceptedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x000041E4 File Offset: 0x000023E4
		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x4CD7F0", Offset = "0x4CBDF0", VA = "0x1804CD7F0")]
		public ulong AddNotifyLeaveSessionRequested(ref AddNotifyLeaveSessionRequestedOptions options, object clientData, OnLeaveSessionRequestedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x000041FC File Offset: 0x000023FC
		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x4CD9B0", Offset = "0x4CBFB0", VA = "0x1804CD9B0")]
		public ulong AddNotifySendSessionNativeInviteRequested(ref AddNotifySendSessionNativeInviteRequestedOptions options, object clientData, OnSendSessionNativeInviteRequestedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00004214 File Offset: 0x00002414
		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x4CDB70", Offset = "0x4CC170", VA = "0x1804CDB70")]
		public ulong AddNotifySessionInviteAccepted(ref AddNotifySessionInviteAcceptedOptions options, object clientData, OnSessionInviteAcceptedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0000422C File Offset: 0x0000242C
		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x4CDD30", Offset = "0x4CC330", VA = "0x1804CDD30")]
		public ulong AddNotifySessionInviteReceived(ref AddNotifySessionInviteReceivedOptions options, object clientData, OnSessionInviteReceivedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00004244 File Offset: 0x00002444
		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x4CDEF0", Offset = "0x4CC4F0", VA = "0x1804CDEF0")]
		public ulong AddNotifySessionInviteRejected(ref AddNotifySessionInviteRejectedOptions options, object clientData, OnSessionInviteRejectedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0000425C File Offset: 0x0000245C
		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x4CE0B0", Offset = "0x4CC6B0", VA = "0x1804CE0B0")]
		public Result CopyActiveSessionHandle(ref CopyActiveSessionHandleOptions options, out ActiveSession outSessionHandle)
		{
			return Result.Success;
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00004274 File Offset: 0x00002474
		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x4CE1C0", Offset = "0x4CC7C0", VA = "0x1804CE1C0")]
		public Result CopySessionHandleByInviteId(ref CopySessionHandleByInviteIdOptions options, out SessionDetails outSessionHandle)
		{
			return Result.Success;
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0000428C File Offset: 0x0000248C
		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x4CE2D0", Offset = "0x4CC8D0", VA = "0x1804CE2D0")]
		public Result CopySessionHandleByUiEventId(ref CopySessionHandleByUiEventIdOptions options, out SessionDetails outSessionHandle)
		{
			return Result.Success;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000042A4 File Offset: 0x000024A4
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x4CE3A0", Offset = "0x4CC9A0", VA = "0x1804CE3A0")]
		public Result CopySessionHandleForPresence(ref CopySessionHandleForPresenceOptions options, out SessionDetails outSessionHandle)
		{
			return Result.Success;
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000042BC File Offset: 0x000024BC
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x4CE4B0", Offset = "0x4CCAB0", VA = "0x1804CE4B0")]
		public Result CreateSessionModification(ref CreateSessionModificationOptions options, out SessionModification outSessionModificationHandle)
		{
			return Result.Success;
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x000042D4 File Offset: 0x000024D4
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x4CE5A0", Offset = "0x4CCBA0", VA = "0x1804CE5A0")]
		public Result CreateSessionSearch(ref CreateSessionSearchOptions options, out SessionSearch outSessionSearchHandle)
		{
			return Result.Success;
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x4CE670", Offset = "0x4CCC70", VA = "0x1804CE670")]
		public void DestroySession(ref DestroySessionOptions options, object clientData, OnDestroySessionCallback completionDelegate)
		{
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x000042EC File Offset: 0x000024EC
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x4CE870", Offset = "0x4CCE70", VA = "0x1804CE870")]
		public Result DumpSessionState(ref DumpSessionStateOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x4CE950", Offset = "0x4CCF50", VA = "0x1804CE950")]
		public void EndSession(ref EndSessionOptions options, object clientData, OnEndSessionCallback completionDelegate)
		{
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00004304 File Offset: 0x00002504
		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x4CEB50", Offset = "0x4CD150", VA = "0x1804CEB50")]
		public uint GetInviteCount(ref GetInviteCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0000431C File Offset: 0x0000251C
		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x4CEC30", Offset = "0x4CD230", VA = "0x1804CEC30")]
		public Result GetInviteIdByIndex(ref GetInviteIdByIndexOptions options, out Utf8String outBuffer)
		{
			return Result.Success;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00004334 File Offset: 0x00002534
		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x4CED60", Offset = "0x4CD360", VA = "0x1804CED60")]
		public Result IsUserInSession(ref IsUserInSessionOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x4CEE00", Offset = "0x4CD400", VA = "0x1804CEE00")]
		public void JoinSession(ref JoinSessionOptions options, object clientData, OnJoinSessionCallback completionDelegate)
		{
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x4CFA00", Offset = "0x4CE000", VA = "0x1804CFA00")]
		public void QueryInvites(ref QueryInvitesOptions options, object clientData, OnQueryInvitesCallback completionDelegate)
		{
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x4CFC00", Offset = "0x4CE200", VA = "0x1804CFC00")]
		public void RegisterPlayers(ref RegisterPlayersOptions options, object clientData, OnRegisterPlayersCallback completionDelegate)
		{
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x4CFE60", Offset = "0x4CE460", VA = "0x1804CFE60")]
		public void RejectInvite(ref RejectInviteOptions options, object clientData, OnRejectInviteCallback completionDelegate)
		{
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x4D0030", Offset = "0x4CE630", VA = "0x1804D0030")]
		public void RemoveNotifyJoinSessionAccepted(ulong inId)
		{
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x4D00A0", Offset = "0x4CE6A0", VA = "0x1804D00A0")]
		public void RemoveNotifyLeaveSessionRequested(ulong inId)
		{
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x4D0110", Offset = "0x4CE710", VA = "0x1804D0110")]
		public void RemoveNotifySendSessionNativeInviteRequested(ulong inId)
		{
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x4D0180", Offset = "0x4CE780", VA = "0x1804D0180")]
		public void RemoveNotifySessionInviteAccepted(ulong inId)
		{
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x4D01F0", Offset = "0x4CE7F0", VA = "0x1804D01F0")]
		public void RemoveNotifySessionInviteReceived(ulong inId)
		{
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x4D0260", Offset = "0x4CE860", VA = "0x1804D0260")]
		public void RemoveNotifySessionInviteRejected(ulong inId)
		{
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x4D02D0", Offset = "0x4CE8D0", VA = "0x1804D02D0")]
		public void SendInvite(ref SendInviteOptions options, object clientData, OnSendInviteCallback completionDelegate)
		{
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x4D04A0", Offset = "0x4CEAA0", VA = "0x1804D04A0")]
		public void StartSession(ref StartSessionOptions options, object clientData, OnStartSessionCallback completionDelegate)
		{
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x4D0660", Offset = "0x4CEC60", VA = "0x1804D0660")]
		public void UnregisterPlayers(ref UnregisterPlayersOptions options, object clientData, OnUnregisterPlayersCallback completionDelegate)
		{
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x4D0910", Offset = "0x4CEF10", VA = "0x1804D0910")]
		public void UpdateSession(ref UpdateSessionOptions options, object clientData, OnUpdateSessionCallback completionDelegate)
		{
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0000434C File Offset: 0x0000254C
		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x4D0830", Offset = "0x4CEE30", VA = "0x1804D0830")]
		public Result UpdateSessionModification(ref UpdateSessionModificationOptions options, out SessionModification outSessionModificationHandle)
		{
			return Result.Success;
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x4CEFD0", Offset = "0x4CD5D0", VA = "0x1804CEFD0")]
		[MonoPInvokeCallback(typeof(OnDestroySessionCallbackInternal))]
		internal static void OnDestroySessionCallbackInternalImplementation(ref DestroySessionCallbackInfoInternal data)
		{
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x4CF070", Offset = "0x4CD670", VA = "0x1804CF070")]
		[MonoPInvokeCallback(typeof(OnEndSessionCallbackInternal))]
		internal static void OnEndSessionCallbackInternalImplementation(ref EndSessionCallbackInfoInternal data)
		{
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x4CF110", Offset = "0x4CD710", VA = "0x1804CF110")]
		[MonoPInvokeCallback(typeof(OnJoinSessionAcceptedCallbackInternal))]
		internal static void OnJoinSessionAcceptedCallbackInternalImplementation(ref JoinSessionAcceptedCallbackInfoInternal data)
		{
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x4CF1B0", Offset = "0x4CD7B0", VA = "0x1804CF1B0")]
		[MonoPInvokeCallback(typeof(OnJoinSessionCallbackInternal))]
		internal static void OnJoinSessionCallbackInternalImplementation(ref JoinSessionCallbackInfoInternal data)
		{
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x4CF250", Offset = "0x4CD850", VA = "0x1804CF250")]
		[MonoPInvokeCallback(typeof(OnLeaveSessionRequestedCallbackInternal))]
		internal static void OnLeaveSessionRequestedCallbackInternalImplementation(ref LeaveSessionRequestedCallbackInfoInternal data)
		{
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x4CF2F0", Offset = "0x4CD8F0", VA = "0x1804CF2F0")]
		[MonoPInvokeCallback(typeof(OnQueryInvitesCallbackInternal))]
		internal static void OnQueryInvitesCallbackInternalImplementation(ref QueryInvitesCallbackInfoInternal data)
		{
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x4CF390", Offset = "0x4CD990", VA = "0x1804CF390")]
		[MonoPInvokeCallback(typeof(OnRegisterPlayersCallbackInternal))]
		internal static void OnRegisterPlayersCallbackInternalImplementation(ref RegisterPlayersCallbackInfoInternal data)
		{
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x4CF430", Offset = "0x4CDA30", VA = "0x1804CF430")]
		[MonoPInvokeCallback(typeof(OnRejectInviteCallbackInternal))]
		internal static void OnRejectInviteCallbackInternalImplementation(ref RejectInviteCallbackInfoInternal data)
		{
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x4CF4D0", Offset = "0x4CDAD0", VA = "0x1804CF4D0")]
		[MonoPInvokeCallback(typeof(OnSendInviteCallbackInternal))]
		internal static void OnSendInviteCallbackInternalImplementation(ref SendInviteCallbackInfoInternal data)
		{
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0x4CF570", Offset = "0x4CDB70", VA = "0x1804CF570")]
		[MonoPInvokeCallback(typeof(OnSendSessionNativeInviteRequestedCallbackInternal))]
		internal static void OnSendSessionNativeInviteRequestedCallbackInternalImplementation(ref SendSessionNativeInviteRequestedCallbackInfoInternal data)
		{
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0x4CF620", Offset = "0x4CDC20", VA = "0x1804CF620")]
		[MonoPInvokeCallback(typeof(OnSessionInviteAcceptedCallbackInternal))]
		internal static void OnSessionInviteAcceptedCallbackInternalImplementation(ref SessionInviteAcceptedCallbackInfoInternal data)
		{
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x4CF6D0", Offset = "0x4CDCD0", VA = "0x1804CF6D0")]
		[MonoPInvokeCallback(typeof(OnSessionInviteReceivedCallbackInternal))]
		internal static void OnSessionInviteReceivedCallbackInternalImplementation(ref SessionInviteReceivedCallbackInfoInternal data)
		{
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x4CF770", Offset = "0x4CDD70", VA = "0x1804CF770")]
		[MonoPInvokeCallback(typeof(OnSessionInviteRejectedCallbackInternal))]
		internal static void OnSessionInviteRejectedCallbackInternalImplementation(ref SessionInviteRejectedCallbackInfoInternal data)
		{
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x4CF820", Offset = "0x4CDE20", VA = "0x1804CF820")]
		[MonoPInvokeCallback(typeof(OnStartSessionCallbackInternal))]
		internal static void OnStartSessionCallbackInternalImplementation(ref StartSessionCallbackInfoInternal data)
		{
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x4CF8C0", Offset = "0x4CDEC0", VA = "0x1804CF8C0")]
		[MonoPInvokeCallback(typeof(OnUnregisterPlayersCallbackInternal))]
		internal static void OnUnregisterPlayersCallbackInternalImplementation(ref UnregisterPlayersCallbackInfoInternal data)
		{
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x4CF960", Offset = "0x4CDF60", VA = "0x1804CF960")]
		[MonoPInvokeCallback(typeof(OnUpdateSessionCallbackInternal))]
		internal static void OnUpdateSessionCallbackInternalImplementation(ref UpdateSessionCallbackInfoInternal data)
		{
		}

		// Token: 0x04000553 RID: 1363
		[Token(Token = "0x4000553")]
		public const int AddnotifyjoinsessionacceptedApiLatest = 1;

		// Token: 0x04000554 RID: 1364
		[Token(Token = "0x4000554")]
		public const int AddnotifyleavesessionrequestedApiLatest = 1;

		// Token: 0x04000555 RID: 1365
		[Token(Token = "0x4000555")]
		public const int AddnotifysendsessionnativeinviterequestedApiLatest = 1;

		// Token: 0x04000556 RID: 1366
		[Token(Token = "0x4000556")]
		public const int AddnotifysessioninviteacceptedApiLatest = 1;

		// Token: 0x04000557 RID: 1367
		[Token(Token = "0x4000557")]
		public const int AddnotifysessioninvitereceivedApiLatest = 1;

		// Token: 0x04000558 RID: 1368
		[Token(Token = "0x4000558")]
		public const int AddnotifysessioninviterejectedApiLatest = 1;

		// Token: 0x04000559 RID: 1369
		[Token(Token = "0x4000559")]
		public const int AttributedataApiLatest = 1;

		// Token: 0x0400055A RID: 1370
		[Token(Token = "0x400055A")]
		public const int CopyactivesessionhandleApiLatest = 1;

		// Token: 0x0400055B RID: 1371
		[Token(Token = "0x400055B")]
		public const int CopysessionhandlebyinviteidApiLatest = 1;

		// Token: 0x0400055C RID: 1372
		[Token(Token = "0x400055C")]
		public const int CopysessionhandlebyuieventidApiLatest = 1;

		// Token: 0x0400055D RID: 1373
		[Token(Token = "0x400055D")]
		public const int CopysessionhandleforpresenceApiLatest = 1;

		// Token: 0x0400055E RID: 1374
		[Token(Token = "0x400055E")]
		public const int CreatesessionmodificationApiLatest = 5;

		// Token: 0x0400055F RID: 1375
		[Token(Token = "0x400055F")]
		public const int CreatesessionsearchApiLatest = 1;

		// Token: 0x04000560 RID: 1376
		[Token(Token = "0x4000560")]
		public const int DestroysessionApiLatest = 1;

		// Token: 0x04000561 RID: 1377
		[Token(Token = "0x4000561")]
		public const int DumpsessionstateApiLatest = 1;

		// Token: 0x04000562 RID: 1378
		[Token(Token = "0x4000562")]
		public const int EndsessionApiLatest = 1;

		// Token: 0x04000563 RID: 1379
		[Token(Token = "0x4000563")]
		public const int GetinvitecountApiLatest = 1;

		// Token: 0x04000564 RID: 1380
		[Token(Token = "0x4000564")]
		public const int GetinviteidbyindexApiLatest = 1;

		// Token: 0x04000565 RID: 1381
		[Token(Token = "0x4000565")]
		public const int InviteidMaxLength = 64;

		// Token: 0x04000566 RID: 1382
		[Token(Token = "0x4000566")]
		public const int IsuserinsessionApiLatest = 1;

		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		public const int JoinsessionApiLatest = 2;

		// Token: 0x04000568 RID: 1384
		[Token(Token = "0x4000568")]
		public const int MaxSearchResults = 200;

		// Token: 0x04000569 RID: 1385
		[Token(Token = "0x4000569")]
		public const int Maxregisteredplayers = 1000;

		// Token: 0x0400056A RID: 1386
		[Token(Token = "0x400056A")]
		public const int QueryinvitesApiLatest = 1;

		// Token: 0x0400056B RID: 1387
		[Token(Token = "0x400056B")]
		public const int RegisterplayersApiLatest = 3;

		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		public const int RejectinviteApiLatest = 1;

		// Token: 0x0400056D RID: 1389
		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Utf8String SearchBucketId;

		// Token: 0x0400056E RID: 1390
		[Token(Token = "0x400056E")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Utf8String SearchEmptyServersOnly;

		// Token: 0x0400056F RID: 1391
		[Token(Token = "0x400056F")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Utf8String SearchMinslotsavailable;

		// Token: 0x04000570 RID: 1392
		[Token(Token = "0x4000570")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Utf8String SearchNonemptyServersOnly;

		// Token: 0x04000571 RID: 1393
		[Token(Token = "0x4000571")]
		public const int SendinviteApiLatest = 1;

		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		public const int SessionattributeApiLatest = 1;

		// Token: 0x04000573 RID: 1395
		[Token(Token = "0x4000573")]
		public const int SessionattributedataApiLatest = 1;

		// Token: 0x04000574 RID: 1396
		[Token(Token = "0x4000574")]
		public const int StartsessionApiLatest = 1;

		// Token: 0x04000575 RID: 1397
		[Token(Token = "0x4000575")]
		public const int UnregisterplayersApiLatest = 2;

		// Token: 0x04000576 RID: 1398
		[Token(Token = "0x4000576")]
		public const int UpdatesessionApiLatest = 1;

		// Token: 0x04000577 RID: 1399
		[Token(Token = "0x4000577")]
		public const int UpdatesessionmodificationApiLatest = 1;
	}
}

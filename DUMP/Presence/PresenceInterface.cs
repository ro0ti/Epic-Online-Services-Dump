using System;


namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002BB RID: 699
	[Token(Token = "0x20002BB")]
	public sealed class PresenceInterface : Handle
	{
		// Token: 0x06001323 RID: 4899 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001323")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public PresenceInterface()
		{
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001324")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public PresenceInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0000593C File Offset: 0x00003B3C
		[Token(Token = "0x6001325")]
		[Address(RVA = "0x4FAF30", Offset = "0x4F9530", VA = "0x1804FAF30")]
		public ulong AddNotifyJoinGameAccepted(ref AddNotifyJoinGameAcceptedOptions options, object clientData, OnJoinGameAcceptedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x00005954 File Offset: 0x00003B54
		[Token(Token = "0x6001326")]
		[Address(RVA = "0x4FB0F0", Offset = "0x4F96F0", VA = "0x1804FB0F0")]
		public ulong AddNotifyOnPresenceChanged(ref AddNotifyOnPresenceChangedOptions options, object clientData, OnPresenceChangedCallback notificationHandler)
		{
			return 0UL;
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x0000596C File Offset: 0x00003B6C
		[Token(Token = "0x6001327")]
		[Address(RVA = "0x4FB2B0", Offset = "0x4F98B0", VA = "0x1804FB2B0")]
		public Result CopyPresence(ref CopyPresenceOptions options, out Info? outPresence)
		{
			return Result.Success;
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x00005984 File Offset: 0x00003B84
		[Token(Token = "0x6001328")]
		[Address(RVA = "0x4FB3B0", Offset = "0x4F99B0", VA = "0x1804FB3B0")]
		public Result CreatePresenceModification(ref CreatePresenceModificationOptions options, out PresenceModification outPresenceModificationHandle)
		{
			return Result.Success;
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0000599C File Offset: 0x00003B9C
		[Token(Token = "0x6001329")]
		[Address(RVA = "0x4FB4C0", Offset = "0x4F9AC0", VA = "0x1804FB4C0")]
		public Result GetJoinInfo(ref GetJoinInfoOptions options, out Utf8String outBuffer)
		{
			return Result.Success;
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x000059B4 File Offset: 0x00003BB4
		[Token(Token = "0x600132A")]
		[Address(RVA = "0x4FB5B0", Offset = "0x4F9BB0", VA = "0x1804FB5B0")]
		public bool HasPresence(ref HasPresenceOptions options)
		{
			return default(bool);
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600132B")]
		[Address(RVA = "0x4FB860", Offset = "0x4F9E60", VA = "0x1804FB860")]
		public void QueryPresence(ref QueryPresenceOptions options, object clientData, OnQueryPresenceCompleteCallback completionDelegate)
		{
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600132C")]
		[Address(RVA = "0x4FBA30", Offset = "0x4FA030", VA = "0x1804FBA30")]
		public void RemoveNotifyJoinGameAccepted(ulong inId)
		{
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600132D")]
		[Address(RVA = "0x4FBAA0", Offset = "0x4FA0A0", VA = "0x1804FBAA0")]
		public void RemoveNotifyOnPresenceChanged(ulong notificationId)
		{
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600132E")]
		[Address(RVA = "0x4FBBB0", Offset = "0x4FA1B0", VA = "0x1804FBBB0")]
		public void SetPresence(ref SetPresenceOptions options, object clientData, SetPresenceCompleteCallback completionDelegate)
		{
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600132F")]
		[Address(RVA = "0x4FB670", Offset = "0x4F9C70", VA = "0x1804FB670")]
		[MonoPInvokeCallback(typeof(OnJoinGameAcceptedCallbackInternal))]
		internal static void OnJoinGameAcceptedCallbackInternalImplementation(ref JoinGameAcceptedCallbackInfoInternal data)
		{
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001330")]
		[Address(RVA = "0x4FB720", Offset = "0x4F9D20", VA = "0x1804FB720")]
		[MonoPInvokeCallback(typeof(OnPresenceChangedCallbackInternal))]
		internal static void OnPresenceChangedCallbackInternalImplementation(ref PresenceChangedCallbackInfoInternal data)
		{
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001331")]
		[Address(RVA = "0x4FB7C0", Offset = "0x4F9DC0", VA = "0x1804FB7C0")]
		[MonoPInvokeCallback(typeof(OnQueryPresenceCompleteCallbackInternal))]
		internal static void OnQueryPresenceCompleteCallbackInternalImplementation(ref QueryPresenceCallbackInfoInternal data)
		{
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001332")]
		[Address(RVA = "0x4FBB10", Offset = "0x4FA110", VA = "0x1804FBB10")]
		[MonoPInvokeCallback(typeof(SetPresenceCompleteCallbackInternal))]
		internal static void SetPresenceCompleteCallbackInternalImplementation(ref SetPresenceCallbackInfoInternal data)
		{
		}

		// Token: 0x04000872 RID: 2162
		[Token(Token = "0x4000872")]
		public const int AddnotifyjoingameacceptedApiLatest = 2;

		// Token: 0x04000873 RID: 2163
		[Token(Token = "0x4000873")]
		public const int AddnotifyonpresencechangedApiLatest = 1;

		// Token: 0x04000874 RID: 2164
		[Token(Token = "0x4000874")]
		public const int CopypresenceApiLatest = 3;

		// Token: 0x04000875 RID: 2165
		[Token(Token = "0x4000875")]
		public const int CreatepresencemodificationApiLatest = 1;

		// Token: 0x04000876 RID: 2166
		[Token(Token = "0x4000876")]
		public const int DataMaxKeyLength = 64;

		// Token: 0x04000877 RID: 2167
		[Token(Token = "0x4000877")]
		public const int DataMaxKeys = 32;

		// Token: 0x04000878 RID: 2168
		[Token(Token = "0x4000878")]
		public const int DataMaxValueLength = 255;

		// Token: 0x04000879 RID: 2169
		[Token(Token = "0x4000879")]
		public const int DatarecordApiLatest = 1;

		// Token: 0x0400087A RID: 2170
		[Token(Token = "0x400087A")]
		public const int DeletedataApiLatest = 1;

		// Token: 0x0400087B RID: 2171
		[Token(Token = "0x400087B")]
		public const int GetjoininfoApiLatest = 1;

		// Token: 0x0400087C RID: 2172
		[Token(Token = "0x400087C")]
		public const int HaspresenceApiLatest = 1;

		// Token: 0x0400087D RID: 2173
		[Token(Token = "0x400087D")]
		public const int InfoApiLatest = 3;

		// Token: 0x0400087E RID: 2174
		[Token(Token = "0x400087E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Utf8String KeyPlatformPresence;

		// Token: 0x0400087F RID: 2175
		[Token(Token = "0x400087F")]
		public const int QuerypresenceApiLatest = 1;

		// Token: 0x04000880 RID: 2176
		[Token(Token = "0x4000880")]
		public const int RichTextMaxValueLength = 255;

		// Token: 0x04000881 RID: 2177
		[Token(Token = "0x4000881")]
		public const int SetdataApiLatest = 1;

		// Token: 0x04000882 RID: 2178
		[Token(Token = "0x4000882")]
		public const int SetpresenceApiLatest = 1;

		// Token: 0x04000883 RID: 2179
		[Token(Token = "0x4000883")]
		public const int SetrawrichtextApiLatest = 1;

		// Token: 0x04000884 RID: 2180
		[Token(Token = "0x4000884")]
		public const int SetstatusApiLatest = 1;
	}
}

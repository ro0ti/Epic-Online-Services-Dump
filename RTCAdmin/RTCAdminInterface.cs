using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x02000250 RID: 592
	[Token(Token = "0x2000250")]
	public sealed class RTCAdminInterface : Handle
	{
		// Token: 0x06001058 RID: 4184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001058")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public RTCAdminInterface()
		{
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001059")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public RTCAdminInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x00005294 File Offset: 0x00003494
		[Token(Token = "0x600105A")]
		[Address(RVA = "0x4E03D0", Offset = "0x4DE9D0", VA = "0x1804E03D0")]
		public Result CopyUserTokenByIndex(ref CopyUserTokenByIndexOptions options, out UserToken? outUserToken)
		{
			return Result.Success;
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x000052AC File Offset: 0x000034AC
		[Token(Token = "0x600105B")]
		[Address(RVA = "0x4E04C0", Offset = "0x4DEAC0", VA = "0x1804E04C0")]
		public Result CopyUserTokenByUserId(ref CopyUserTokenByUserIdOptions options, out UserToken? outUserToken)
		{
			return Result.Success;
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600105C")]
		[Address(RVA = "0x4E0610", Offset = "0x4DEC10", VA = "0x1804E0610")]
		public void Kick(ref KickOptions options, object clientData, OnKickCompleteCallback completionDelegate)
		{
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600105D")]
		[Address(RVA = "0x4E09D0", Offset = "0x4DEFD0", VA = "0x1804E09D0")]
		public void QueryJoinRoomToken(ref QueryJoinRoomTokenOptions options, object clientData, OnQueryJoinRoomTokenCompleteCallback completionDelegate)
		{
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600105E")]
		[Address(RVA = "0x4E0BA0", Offset = "0x4DF1A0", VA = "0x1804E0BA0")]
		public void SetParticipantHardMute(ref SetParticipantHardMuteOptions options, object clientData, OnSetParticipantHardMuteCompleteCallback completionDelegate)
		{
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600105F")]
		[Address(RVA = "0x4E07E0", Offset = "0x4DEDE0", VA = "0x1804E07E0")]
		[MonoPInvokeCallback(typeof(OnKickCompleteCallbackInternal))]
		internal static void OnKickCompleteCallbackInternalImplementation(ref KickCompleteCallbackInfoInternal data)
		{
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001060")]
		[Address(RVA = "0x4E0880", Offset = "0x4DEE80", VA = "0x1804E0880")]
		[MonoPInvokeCallback(typeof(OnQueryJoinRoomTokenCompleteCallbackInternal))]
		internal static void OnQueryJoinRoomTokenCompleteCallbackInternalImplementation(ref QueryJoinRoomTokenCompleteCallbackInfoInternal data)
		{
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001061")]
		[Address(RVA = "0x4E0930", Offset = "0x4DEF30", VA = "0x1804E0930")]
		[MonoPInvokeCallback(typeof(OnSetParticipantHardMuteCompleteCallbackInternal))]
		internal static void OnSetParticipantHardMuteCompleteCallbackInternalImplementation(ref SetParticipantHardMuteCompleteCallbackInfoInternal data)
		{
		}

		// Token: 0x04000746 RID: 1862
		[Token(Token = "0x4000746")]
		public const int CopyusertokenbyindexApiLatest = 2;

		// Token: 0x04000747 RID: 1863
		[Token(Token = "0x4000747")]
		public const int CopyusertokenbyuseridApiLatest = 2;

		// Token: 0x04000748 RID: 1864
		[Token(Token = "0x4000748")]
		public const int KickApiLatest = 1;

		// Token: 0x04000749 RID: 1865
		[Token(Token = "0x4000749")]
		public const int QueryjoinroomtokenApiLatest = 2;

		// Token: 0x0400074A RID: 1866
		[Token(Token = "0x400074A")]
		public const int SetparticipanthardmuteApiLatest = 1;

		// Token: 0x0400074B RID: 1867
		[Token(Token = "0x400074B")]
		public const int UsertokenApiLatest = 1;
	}
}

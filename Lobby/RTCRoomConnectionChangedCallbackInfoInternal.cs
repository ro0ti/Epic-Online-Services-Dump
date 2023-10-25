using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200046F RID: 1135
	[Token(Token = "0x200046F")]
	internal struct RTCRoomConnectionChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<RTCRoomConnectionChangedCallbackInfo>, ISettable<RTCRoomConnectionChangedCallbackInfo>, IDisposable
	{
		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001D5D RID: 7517 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D5E RID: 7518 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000836")]
		public object ClientData
		{
			[Token(Token = "0x6001D5D")]
			[Address(RVA = "0x534D20", Offset = "0x533320", VA = "0x180534D20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D5E")]
			[Address(RVA = "0x534EE0", Offset = "0x5334E0", VA = "0x180534EE0")]
			set
			{
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001D5F RID: 7519 RVA: 0x000080E4 File Offset: 0x000062E4
		[Token(Token = "0x17000837")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001D5F")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000838")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001D60")]
			[Address(RVA = "0x534DF0", Offset = "0x5333F0", VA = "0x180534DF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D61")]
			[Address(RVA = "0x534FA0", Offset = "0x5335A0", VA = "0x180534FA0")]
			set
			{
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D63 RID: 7523 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000839")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001D62")]
			[Address(RVA = "0x534E60", Offset = "0x533460", VA = "0x180534E60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D63")]
			[Address(RVA = "0x535000", Offset = "0x533600", VA = "0x180535000")]
			set
			{
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001D64 RID: 7524 RVA: 0x000080FC File Offset: 0x000062FC
		// (set) Token: 0x06001D65 RID: 7525 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700083A")]
		public bool IsConnected
		{
			[Token(Token = "0x6001D64")]
			[Address(RVA = "0x534D90", Offset = "0x533390", VA = "0x180534D90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D65")]
			[Address(RVA = "0x534F40", Offset = "0x533540", VA = "0x180534F40")]
			set
			{
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x00008114 File Offset: 0x00006314
		// (set) Token: 0x06001D67 RID: 7527 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700083B")]
		public Result DisconnectReason
		{
			[Token(Token = "0x6001D66")]
			[Address(RVA = "0x4A5AF0", Offset = "0x4A40F0", VA = "0x1804A5AF0")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001D67")]
			[Address(RVA = "0x4A5CB0", Offset = "0x4A42B0", VA = "0x1804A5CB0")]
			set
			{
			}
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D68")]
		[Address(RVA = "0x534BD0", Offset = "0x5331D0", VA = "0x180534BD0", Slot = "6")]
		public void Set(ref RTCRoomConnectionChangedCallbackInfo other)
		{
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D69")]
		[Address(RVA = "0x534A00", Offset = "0x533000", VA = "0x180534A00", Slot = "7")]
		public void Set(ref RTCRoomConnectionChangedCallbackInfo? other)
		{
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D6A")]
		[Address(RVA = "0x534980", Offset = "0x532F80", VA = "0x180534980", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D6B")]
		[Address(RVA = "0x5349E0", Offset = "0x532FE0", VA = "0x1805349E0", Slot = "5")]
		public void Get(out RTCRoomConnectionChangedCallbackInfo output)
		{
		}

		// Token: 0x04000D07 RID: 3335
		[Token(Token = "0x4000D07")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000D08 RID: 3336
		[Token(Token = "0x4000D08")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LobbyId;

		// Token: 0x04000D09 RID: 3337
		[Token(Token = "0x4000D09")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000D0A RID: 3338
		[Token(Token = "0x4000D0A")]
		[FieldOffset(Offset = "0x18")]
		private int m_IsConnected;

		// Token: 0x04000D0B RID: 3339
		[Token(Token = "0x4000D0B")]
		[FieldOffset(Offset = "0x1C")]
		private Result m_DisconnectReason;
	}
}

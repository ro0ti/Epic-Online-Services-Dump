using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005DD RID: 1501
	[Token(Token = "0x20005DD")]
	internal struct SendCustomInviteCallbackInfoInternal : ICallbackInfoInternal, IGettable<SendCustomInviteCallbackInfo>, ISettable<SendCustomInviteCallbackInfo>, IDisposable
	{
		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x0600267F RID: 9855 RVA: 0x00009D64 File Offset: 0x00007F64
		// (set) Token: 0x06002680 RID: 9856 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B25")]
		public Result ResultCode
		{
			[Token(Token = "0x600267F")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002680")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06002681 RID: 9857 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002682 RID: 9858 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B26")]
		public object ClientData
		{
			[Token(Token = "0x6002681")]
			[Address(RVA = "0x566960", Offset = "0x564F60", VA = "0x180566960")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002682")]
			[Address(RVA = "0x566AE0", Offset = "0x5650E0", VA = "0x180566AE0")]
			set
			{
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06002683 RID: 9859 RVA: 0x00009D7C File Offset: 0x00007F7C
		[Token(Token = "0x17000B27")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002683")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06002684 RID: 9860 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002685 RID: 9861 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B28")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002684")]
			[Address(RVA = "0x5669D0", Offset = "0x564FD0", VA = "0x1805669D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002685")]
			[Address(RVA = "0x566B40", Offset = "0x565140", VA = "0x180566B40")]
			set
			{
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06002686 RID: 9862 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002687 RID: 9863 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B29")]
		public ProductUserId[] TargetUserIds
		{
			[Token(Token = "0x6002686")]
			[Address(RVA = "0x566A50", Offset = "0x565050", VA = "0x180566A50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002687")]
			[Address(RVA = "0x566BA0", Offset = "0x5651A0", VA = "0x180566BA0")]
			set
			{
			}
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002688")]
		[Address(RVA = "0x566890", Offset = "0x564E90", VA = "0x180566890", Slot = "6")]
		public void Set(ref SendCustomInviteCallbackInfo other)
		{
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002689")]
		[Address(RVA = "0x566750", Offset = "0x564D50", VA = "0x180566750", Slot = "7")]
		public void Set(ref SendCustomInviteCallbackInfo? other)
		{
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600268A")]
		[Address(RVA = "0x5666C0", Offset = "0x564CC0", VA = "0x1805666C0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600268B")]
		[Address(RVA = "0x566730", Offset = "0x564D30", VA = "0x180566730", Slot = "5")]
		public void Get(out SendCustomInviteCallbackInfo output)
		{
		}

		// Token: 0x040010DC RID: 4316
		[Token(Token = "0x40010DC")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040010DD RID: 4317
		[Token(Token = "0x40010DD")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040010DE RID: 4318
		[Token(Token = "0x40010DE")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040010DF RID: 4319
		[Token(Token = "0x40010DF")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserIds;

		// Token: 0x040010E0 RID: 4320
		[Token(Token = "0x40010E0")]
		[FieldOffset(Offset = "0x20")]
		private uint m_TargetUserIdsCount;
	}
}

using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.ProgressionSnapshot
{
	// Token: 0x02000293 RID: 659
	[Token(Token = "0x2000293")]
	internal struct DeleteSnapshotCallbackInfoInternal : ICallbackInfoInternal, IGettable<DeleteSnapshotCallbackInfo>, ISettable<DeleteSnapshotCallbackInfo>, IDisposable
	{
		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001237 RID: 4663 RVA: 0x00005744 File Offset: 0x00003944
		// (set) Token: 0x06001238 RID: 4664 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004C4")]
		public Result ResultCode
		{
			[Token(Token = "0x6001237")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001238")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600123A RID: 4666 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004C5")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001239")]
			[Address(RVA = "0x4F0270", Offset = "0x4EE870", VA = "0x1804F0270")]
			get
			{
				return null;
			}
			[Token(Token = "0x600123A")]
			[Address(RVA = "0x4F0350", Offset = "0x4EE950", VA = "0x1804F0350")]
			set
			{
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600123C RID: 4668 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004C6")]
		public object ClientData
		{
			[Token(Token = "0x600123B")]
			[Address(RVA = "0x4F0200", Offset = "0x4EE800", VA = "0x1804F0200")]
			get
			{
				return null;
			}
			[Token(Token = "0x600123C")]
			[Address(RVA = "0x4F02F0", Offset = "0x4EE8F0", VA = "0x1804F02F0")]
			set
			{
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x0000575C File Offset: 0x0000395C
		[Token(Token = "0x170004C7")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600123D")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600123E")]
		[Address(RVA = "0x4F0020", Offset = "0x4EE620", VA = "0x1804F0020", Slot = "6")]
		public void Set(ref DeleteSnapshotCallbackInfo other)
		{
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600123F")]
		[Address(RVA = "0x4F00E0", Offset = "0x4EE6E0", VA = "0x1804F00E0", Slot = "7")]
		public void Set(ref DeleteSnapshotCallbackInfo? other)
		{
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001240")]
		[Address(RVA = "0x4EFFA0", Offset = "0x4EE5A0", VA = "0x1804EFFA0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001241")]
		[Address(RVA = "0x4F0000", Offset = "0x4EE600", VA = "0x1804F0000", Slot = "5")]
		public void Get(out DeleteSnapshotCallbackInfo output)
		{
		}

		// Token: 0x0400081D RID: 2077
		[Token(Token = "0x400081D")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400081E RID: 2078
		[Token(Token = "0x400081E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400081F RID: 2079
		[Token(Token = "0x400081F")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ClientData;
	}
}

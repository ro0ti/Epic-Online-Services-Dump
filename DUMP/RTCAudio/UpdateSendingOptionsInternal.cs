using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000239 RID: 569
	[Token(Token = "0x2000239")]
	internal struct UpdateSendingOptionsInternal : ISettable<UpdateSendingOptions>, IDisposable
	{
		// Token: 0x170003E3 RID: 995
		// (set) Token: 0x06000FBB RID: 4027 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003E3")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000FBB")]
			[Address(RVA = "0x4EA510", Offset = "0x4E8B10", VA = "0x1804EA510")]
			set
			{
			}
		}

		// Token: 0x170003E4 RID: 996
		// (set) Token: 0x06000FBC RID: 4028 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003E4")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000FBC")]
			[Address(RVA = "0x4EA570", Offset = "0x4E8B70", VA = "0x1804EA570")]
			set
			{
			}
		}

		// Token: 0x170003E5 RID: 997
		// (set) Token: 0x06000FBD RID: 4029 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003E5")]
		public RTCAudioStatus AudioStatus
		{
			[Token(Token = "0x6000FBD")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FBE")]
		[Address(RVA = "0x4EA310", Offset = "0x4E8910", VA = "0x1804EA310", Slot = "4")]
		public void Set(ref UpdateSendingOptions other)
		{
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FBF")]
		[Address(RVA = "0x4EA3E0", Offset = "0x4E89E0", VA = "0x1804EA3E0", Slot = "5")]
		public void Set(ref UpdateSendingOptions? other)
		{
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FC0")]
		[Address(RVA = "0x4EA2B0", Offset = "0x4E88B0", VA = "0x1804EA2B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000708 RID: 1800
		[Token(Token = "0x4000708")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000709 RID: 1801
		[Token(Token = "0x4000709")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400070A RID: 1802
		[Token(Token = "0x400070A")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;

		// Token: 0x0400070B RID: 1803
		[Token(Token = "0x400070B")]
		[FieldOffset(Offset = "0x18")]
		private RTCAudioStatus m_AudioStatus;
	}
}

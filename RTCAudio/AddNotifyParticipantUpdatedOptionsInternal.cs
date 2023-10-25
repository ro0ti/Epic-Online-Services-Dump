using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001BB RID: 443
	[Token(Token = "0x20001BB")]
	internal struct AddNotifyParticipantUpdatedOptionsInternal : ISettable<AddNotifyParticipantUpdatedOptions>, IDisposable
	{
		// Token: 0x170002F0 RID: 752
		// (set) Token: 0x06000C8C RID: 3212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002F0")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000C8C")]
			[Address(RVA = "0x4D41B0", Offset = "0x4D27B0", VA = "0x1804D41B0")]
			set
			{
			}
		}

		// Token: 0x170002F1 RID: 753
		// (set) Token: 0x06000C8D RID: 3213 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002F1")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000C8D")]
			[Address(RVA = "0x4D4210", Offset = "0x4D2810", VA = "0x1804D4210")]
			set
			{
			}
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C8E")]
		[Address(RVA = "0x4D3FE0", Offset = "0x4D25E0", VA = "0x1804D3FE0", Slot = "4")]
		public void Set(ref AddNotifyParticipantUpdatedOptions other)
		{
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C8F")]
		[Address(RVA = "0x4D40A0", Offset = "0x4D26A0", VA = "0x1804D40A0", Slot = "5")]
		public void Set(ref AddNotifyParticipantUpdatedOptions? other)
		{
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C90")]
		[Address(RVA = "0x4D3F80", Offset = "0x4D2580", VA = "0x1804D3F80", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040005D5 RID: 1493
		[Token(Token = "0x40005D5")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040005D6 RID: 1494
		[Token(Token = "0x40005D6")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040005D7 RID: 1495
		[Token(Token = "0x40005D7")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;
	}
}

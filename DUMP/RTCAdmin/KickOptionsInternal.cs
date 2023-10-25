using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x02000245 RID: 581
	[Token(Token = "0x2000245")]
	internal struct KickOptionsInternal : ISettable<KickOptions>, IDisposable
	{
		// Token: 0x17000406 RID: 1030
		// (set) Token: 0x0600100D RID: 4109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000406")]
		public Utf8String RoomName
		{
			[Token(Token = "0x600100D")]
			[Address(RVA = "0x4DA3D0", Offset = "0x4D89D0", VA = "0x1804DA3D0")]
			set
			{
			}
		}

		// Token: 0x17000407 RID: 1031
		// (set) Token: 0x0600100E RID: 4110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000407")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x600100E")]
			[Address(RVA = "0x4DA430", Offset = "0x4D8A30", VA = "0x1804DA430")]
			set
			{
			}
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600100F")]
		[Address(RVA = "0x4DA310", Offset = "0x4D8910", VA = "0x1804DA310", Slot = "4")]
		public void Set(ref KickOptions other)
		{
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001010")]
		[Address(RVA = "0x4DA200", Offset = "0x4D8800", VA = "0x1804DA200", Slot = "5")]
		public void Set(ref KickOptions? other)
		{
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001011")]
		[Address(RVA = "0x4DA1A0", Offset = "0x4D87A0", VA = "0x1804DA1A0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400072D RID: 1837
		[Token(Token = "0x400072D")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400072E RID: 1838
		[Token(Token = "0x400072E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_RoomName;

		// Token: 0x0400072F RID: 1839
		[Token(Token = "0x400072F")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}

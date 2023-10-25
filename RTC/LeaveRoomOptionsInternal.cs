using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTC
{
	// Token: 0x0200026B RID: 619
	[Token(Token = "0x200026B")]
	internal struct LeaveRoomOptionsInternal : ISettable<LeaveRoomOptions>, IDisposable
	{
		// Token: 0x1700047C RID: 1148
		// (set) Token: 0x0600113B RID: 4411 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700047C")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600113B")]
			[Address(RVA = "0x4F5B60", Offset = "0x4F4160", VA = "0x1804F5B60")]
			set
			{
			}
		}

		// Token: 0x1700047D RID: 1149
		// (set) Token: 0x0600113C RID: 4412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700047D")]
		public Utf8String RoomName
		{
			[Token(Token = "0x600113C")]
			[Address(RVA = "0x4F5BC0", Offset = "0x4F41C0", VA = "0x1804F5BC0")]
			set
			{
			}
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600113D")]
		[Address(RVA = "0x4F5990", Offset = "0x4F3F90", VA = "0x1804F5990", Slot = "4")]
		public void Set(ref LeaveRoomOptions other)
		{
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600113E")]
		[Address(RVA = "0x4F5A50", Offset = "0x4F4050", VA = "0x1804F5A50", Slot = "5")]
		public void Set(ref LeaveRoomOptions? other)
		{
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600113F")]
		[Address(RVA = "0x4F5930", Offset = "0x4F3F30", VA = "0x1804F5930", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040007B2 RID: 1970
		[Token(Token = "0x40007B2")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040007B3 RID: 1971
		[Token(Token = "0x40007B3")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040007B4 RID: 1972
		[Token(Token = "0x40007B4")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;
	}
}

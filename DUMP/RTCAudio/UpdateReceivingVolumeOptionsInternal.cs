using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000235 RID: 565
	[Token(Token = "0x2000235")]
	internal struct UpdateReceivingVolumeOptionsInternal : ISettable<UpdateReceivingVolumeOptions>, IDisposable
	{
		// Token: 0x170003D2 RID: 978
		// (set) Token: 0x06000F94 RID: 3988 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003D2")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000F94")]
			[Address(RVA = "0x4E9AD0", Offset = "0x4E80D0", VA = "0x1804E9AD0")]
			set
			{
			}
		}

		// Token: 0x170003D3 RID: 979
		// (set) Token: 0x06000F95 RID: 3989 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003D3")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000F95")]
			[Address(RVA = "0x4E9B30", Offset = "0x4E8130", VA = "0x1804E9B30")]
			set
			{
			}
		}

		// Token: 0x170003D4 RID: 980
		// (set) Token: 0x06000F96 RID: 3990 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003D4")]
		public float Volume
		{
			[Token(Token = "0x6000F96")]
			[Address(RVA = "0x4AFB80", Offset = "0x4AE180", VA = "0x1804AFB80")]
			set
			{
			}
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F97")]
		[Address(RVA = "0x4E9A00", Offset = "0x4E8000", VA = "0x1804E9A00", Slot = "4")]
		public void Set(ref UpdateReceivingVolumeOptions other)
		{
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F98")]
		[Address(RVA = "0x4E98D0", Offset = "0x4E7ED0", VA = "0x1804E98D0", Slot = "5")]
		public void Set(ref UpdateReceivingVolumeOptions? other)
		{
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F99")]
		[Address(RVA = "0x4E9870", Offset = "0x4E7E70", VA = "0x1804E9870", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040006F7 RID: 1783
		[Token(Token = "0x40006F7")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040006F8 RID: 1784
		[Token(Token = "0x40006F8")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040006F9 RID: 1785
		[Token(Token = "0x40006F9")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;

		// Token: 0x040006FA RID: 1786
		[Token(Token = "0x40006FA")]
		[FieldOffset(Offset = "0x18")]
		private float m_Volume;
	}
}

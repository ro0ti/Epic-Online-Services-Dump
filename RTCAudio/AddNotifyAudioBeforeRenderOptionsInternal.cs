using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001B1 RID: 433
	[Token(Token = "0x20001B1")]
	internal struct AddNotifyAudioBeforeRenderOptionsInternal : ISettable<AddNotifyAudioBeforeRenderOptions>, IDisposable
	{
		// Token: 0x170002DF RID: 735
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002DF")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000C64")]
			[Address(RVA = "0x4D2F60", Offset = "0x4D1560", VA = "0x1804D2F60")]
			set
			{
			}
		}

		// Token: 0x170002E0 RID: 736
		// (set) Token: 0x06000C65 RID: 3173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002E0")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000C65")]
			[Address(RVA = "0x4D2FC0", Offset = "0x4D15C0", VA = "0x1804D2FC0")]
			set
			{
			}
		}

		// Token: 0x170002E1 RID: 737
		// (set) Token: 0x06000C66 RID: 3174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002E1")]
		public bool UnmixedAudio
		{
			[Token(Token = "0x6000C66")]
			[Address(RVA = "0x4D3020", Offset = "0x4D1620", VA = "0x1804D3020")]
			set
			{
			}
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C67")]
		[Address(RVA = "0x4D2E60", Offset = "0x4D1460", VA = "0x1804D2E60", Slot = "4")]
		public void Set(ref AddNotifyAudioBeforeRenderOptions other)
		{
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C68")]
		[Address(RVA = "0x4D2D00", Offset = "0x4D1300", VA = "0x1804D2D00", Slot = "5")]
		public void Set(ref AddNotifyAudioBeforeRenderOptions? other)
		{
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C69")]
		[Address(RVA = "0x4D2CA0", Offset = "0x4D12A0", VA = "0x1804D2CA0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040005BF RID: 1471
		[Token(Token = "0x40005BF")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040005C0 RID: 1472
		[Token(Token = "0x40005C0")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040005C1 RID: 1473
		[Token(Token = "0x40005C1")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;

		// Token: 0x040005C2 RID: 1474
		[Token(Token = "0x40005C2")]
		[FieldOffset(Offset = "0x18")]
		private int m_UnmixedAudio;
	}
}

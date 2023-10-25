using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002C2 RID: 706
	[Token(Token = "0x20002C2")]
	internal struct PresenceModificationSetDataOptionsInternal : ISettable<PresenceModificationSetDataOptions>, IDisposable
	{
		// Token: 0x17000510 RID: 1296
		// (set) Token: 0x0600134D RID: 4941 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000510")]
		public DataRecord[] Records
		{
			[Token(Token = "0x600134D")]
			[Address(RVA = "0x4FC2F0", Offset = "0x4FA8F0", VA = "0x1804FC2F0")]
			set
			{
			}
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600134E")]
		[Address(RVA = "0x4FC2D0", Offset = "0x4FA8D0", VA = "0x1804FC2D0", Slot = "4")]
		public void Set(ref PresenceModificationSetDataOptions other)
		{
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600134F")]
		[Address(RVA = "0x4FC260", Offset = "0x4FA860", VA = "0x1804FC260", Slot = "5")]
		public void Set(ref PresenceModificationSetDataOptions? other)
		{
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001350")]
		[Address(RVA = "0x4FC210", Offset = "0x4FA810", VA = "0x1804FC210", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000894 RID: 2196
		[Token(Token = "0x4000894")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000895 RID: 2197
		[Token(Token = "0x4000895")]
		[FieldOffset(Offset = "0x4")]
		private int m_RecordsCount;

		// Token: 0x04000896 RID: 2198
		[Token(Token = "0x4000896")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Records;
	}
}

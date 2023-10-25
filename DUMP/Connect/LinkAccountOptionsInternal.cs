using System;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000614 RID: 1556
	[Token(Token = "0x2000614")]
	internal struct LinkAccountOptionsInternal : ISettable<LinkAccountOptions>, IDisposable
	{
		// Token: 0x17000B9F RID: 2975
		// (set) Token: 0x060027E8 RID: 10216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B9F")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60027E8")]
			[Address(RVA = "0x55D390", Offset = "0x55B990", VA = "0x18055D390")]
			set
			{
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (set) Token: 0x060027E9 RID: 10217 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BA0")]
		public ContinuanceToken ContinuanceToken
		{
			[Token(Token = "0x60027E9")]
			[Address(RVA = "0x55D270", Offset = "0x55B870", VA = "0x18055D270")]
			set
			{
			}
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027EA")]
		[Address(RVA = "0x55CEA0", Offset = "0x55B4A0", VA = "0x18055CEA0", Slot = "4")]
		public void Set(ref LinkAccountOptions other)
		{
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027EB")]
		[Address(RVA = "0x55D160", Offset = "0x55B760", VA = "0x18055D160", Slot = "5")]
		public void Set(ref LinkAccountOptions? other)
		{
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027EC")]
		[Address(RVA = "0x55CE40", Offset = "0x55B440", VA = "0x18055CE40", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001182 RID: 4482
		[Token(Token = "0x4001182")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001183 RID: 4483
		[Token(Token = "0x4001183")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001184 RID: 4484
		[Token(Token = "0x4001184")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ContinuanceToken;
	}
}

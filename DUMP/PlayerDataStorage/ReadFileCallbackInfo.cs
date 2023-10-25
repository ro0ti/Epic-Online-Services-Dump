using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x02000308 RID: 776
	[Token(Token = "0x2000308")]
	public struct ReadFileCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x00005F3C File Offset: 0x0000413C
		// (set) Token: 0x060014ED RID: 5357 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000585")]
		public Result ResultCode
		{
			[Token(Token = "0x60014EC")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60014ED")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060014EF RID: 5359 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000586")]
		public object ClientData
		{
			[Token(Token = "0x60014EE")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60014EF")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060014F1 RID: 5361 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000587")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60014F0")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60014F1")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060014F3 RID: 5363 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000588")]
		public Utf8String Filename
		{
			[Token(Token = "0x60014F2")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60014F3")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00005F54 File Offset: 0x00004154
		[Token(Token = "0x60014F4")]
		[Address(RVA = "0x5002D0", Offset = "0x4FE8D0", VA = "0x1805002D0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014F5")]
		[Address(RVA = "0x500320", Offset = "0x4FE920", VA = "0x180500320")]
		internal void Set(ref ReadFileCallbackInfoInternal other)
		{
		}
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Memory
{
	public class MemoryManager : MemoryObject
	{
		// 2.0.0.20874
		public const int SizeOf = 0x38;

		public MemoryManager(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int _x00 { get { return Field<int>(0x00); } }
		public int _x04 { get { return Field<int>(0x04); } }
		public int _x08 { get { return Field<int>(0x08); } }
		public int _x0C { get { return Field<int>(0x0C); } }
		public int _x10 { get { return Field<int>(0x10); } }
		public int _x14 { get { return Field<int>(0x14); } }
		public int _x18 { get { return Field<int>(0x18); } }
		public int _x1C { get { return Field<int>(0x1C); } }
		public int _x20 { get { return Field<int>(0x20); } }
		public int _x24 { get { return Field<int>(0x24); } }
		public int _x28 { get { return Field<int>(0x28); } }
		public int x2C_IsInitialized_ { get { return Field<int>(0x2C); } }
		public VTable x30_MethodTable { get { return Dereference<Pointer<VTable>>(0x30).Value; } }
		public int x34_Method_ { get { return Field<int>(0x34); } }



		public class VTable : MemoryObject
		{
			public const int SizeOf = 0x18;

			public VTable(ProcessMemory memory, int address)
				: base(memory, address) { }

			public int _x00 { get { return Field<int>(0x00); } }
			public int x04_MemAlloc { get { return Field<int>(0x04); } }
			public int _x08 { get { return Field<int>(0x08); } }
			public int _x0C { get { return Field<int>(0x0C); } }
			public int x10_MemResize { get { return Field<int>(0x10); } }
			public int _x14 { get { return Field<int>(0x14); } }
		}
	}
}

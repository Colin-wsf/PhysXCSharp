// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: Scene.proto

#pragma warning disable CS1591, CS0612, CS3021, IDE1006
namespace Engine.PhysX
{

	[global::ProtoBuf.ProtoContract()]
	public partial class U3DPhysxScene : global::ProtoBuf.IExtensible
	{
		private global::ProtoBuf.IExtension __pbn__extensionData;
		global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
			=> global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

		[global::ProtoBuf.ProtoMember(1)]
		[global::System.ComponentModel.DefaultValue("")]
		public string sceneName { get; set; } = "";

		[global::ProtoBuf.ProtoMember(2)]
		public global::System.Collections.Generic.List<U3DPhysxBox> boxColliders { get; } = new global::System.Collections.Generic.List<U3DPhysxBox>();

		[global::ProtoBuf.ProtoMember(3)]
		public global::System.Collections.Generic.List<U3DPhysxSphere> sphereColliders { get; } = new global::System.Collections.Generic.List<U3DPhysxSphere>();

		[global::ProtoBuf.ProtoMember(4)]
		public global::System.Collections.Generic.List<U3DPhysxCapsule> capsuleColliders { get; } = new global::System.Collections.Generic.List<U3DPhysxCapsule>();

		[global::ProtoBuf.ProtoMember(5)]
		public global::System.Collections.Generic.List<U3DPhysxMesh> meshColliders { get; } = new global::System.Collections.Generic.List<U3DPhysxMesh>();

	}

	[global::ProtoBuf.ProtoContract()]
	public partial class U3DPhysxSphere : global::ProtoBuf.IExtensible
	{
		private global::ProtoBuf.IExtension __pbn__extensionData;
		global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
			=> global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

		[global::ProtoBuf.ProtoMember(1, Name = @"layer")]
		public int Layer { get; set; }

		[global::ProtoBuf.ProtoMember(2, Name = @"position")]
		public ProtoVec3 Position { get; set; }

		[global::ProtoBuf.ProtoMember(3, Name = @"radius")]
		public float Radius { get; set; }

		[global::ProtoBuf.ProtoMember(4, Name = @"rotation")]
		public ProtoVec4 Rotation { get; set; }

		[global::ProtoBuf.ProtoMember(5)]
		[global::System.ComponentModel.DefaultValue("")]
		public string Name { get; set; } = "";

	}

	[global::ProtoBuf.ProtoContract()]
	public partial class U3DPhysxBox : global::ProtoBuf.IExtensible
	{
		private global::ProtoBuf.IExtension __pbn__extensionData;
		global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
			=> global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

		[global::ProtoBuf.ProtoMember(1, Name = @"layer")]
		public int Layer { get; set; }

		[global::ProtoBuf.ProtoMember(2, Name = @"position")]
		public ProtoVec3 Position { get; set; }

		[global::ProtoBuf.ProtoMember(3)]
		public float xExtents { get; set; }

		[global::ProtoBuf.ProtoMember(4)]
		public float yExtents { get; set; }

		[global::ProtoBuf.ProtoMember(5)]
		public float zExtents { get; set; }

		[global::ProtoBuf.ProtoMember(6, Name = @"rotation")]
		public ProtoVec4 Rotation { get; set; }

		[global::ProtoBuf.ProtoMember(7)]
		[global::System.ComponentModel.DefaultValue("")]
		public string Name { get; set; } = "";

	}

	[global::ProtoBuf.ProtoContract()]
	public partial class U3DPhysxCapsule : global::ProtoBuf.IExtensible
	{
		private global::ProtoBuf.IExtension __pbn__extensionData;
		global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
			=> global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

		[global::ProtoBuf.ProtoMember(1, Name = @"layer")]
		public int Layer { get; set; }

		[global::ProtoBuf.ProtoMember(2, Name = @"position")]
		public ProtoVec3 Position { get; set; }

		[global::ProtoBuf.ProtoMember(3, Name = @"radius")]
		public float Radius { get; set; }

		[global::ProtoBuf.ProtoMember(4)]
		public float halfHeight { get; set; }

		[global::ProtoBuf.ProtoMember(5, Name = @"rotation")]
		public ProtoVec4 Rotation { get; set; }

		[global::ProtoBuf.ProtoMember(6, Name = @"direction")]
		public int Direction { get; set; }

		[global::ProtoBuf.ProtoMember(7)]
		[global::System.ComponentModel.DefaultValue("")]
		public string Name { get; set; } = "";

	}

	[global::ProtoBuf.ProtoContract()]
	public partial class U3DPhysxMesh : global::ProtoBuf.IExtensible
	{
		private global::ProtoBuf.IExtension __pbn__extensionData;
		global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
			=> global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

		[global::ProtoBuf.ProtoMember(1, Name = @"layer")]
		public int Layer { get; set; }

		[global::ProtoBuf.ProtoMember(2, Name = @"vertices")]
		public global::System.Collections.Generic.List<ProtoVec3> Vertices { get; } = new global::System.Collections.Generic.List<ProtoVec3>();

		[global::ProtoBuf.ProtoMember(3, Name = @"rotation")]
		public ProtoVec4 Rotation { get; set; }

		[global::ProtoBuf.ProtoMember(4, Name = @"position")]
		public ProtoVec3 Position { get; set; }

		[global::ProtoBuf.ProtoMember(5, Name = @"scale")]
		public ProtoVec3 Scale { get; set; }

		[global::ProtoBuf.ProtoMember(6, Name = @"triangles", IsPacked = true)]
		public int[] Triangles { get; set; }

		[global::ProtoBuf.ProtoMember(7)]
		[global::System.ComponentModel.DefaultValue("")]
		public string Name { get; set; } = "";

	}

	[global::ProtoBuf.ProtoContract()]
	public partial class ProtoVec3 : global::ProtoBuf.IExtensible
	{
		private global::ProtoBuf.IExtension __pbn__extensionData;
		global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
			=> global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

		[global::ProtoBuf.ProtoMember(1, Name = @"x")]
		public float X { get; set; }

		[global::ProtoBuf.ProtoMember(2, Name = @"y")]
		public float Y { get; set; }

		[global::ProtoBuf.ProtoMember(3, Name = @"z")]
		public float Z { get; set; }

	}

	[global::ProtoBuf.ProtoContract()]
	public partial class ProtoVec4 : global::ProtoBuf.IExtensible
	{
		private global::ProtoBuf.IExtension __pbn__extensionData;
		global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
			=> global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

		[global::ProtoBuf.ProtoMember(1, Name = @"x")]
		public float X { get; set; }

		[global::ProtoBuf.ProtoMember(2, Name = @"y")]
		public float Y { get; set; }

		[global::ProtoBuf.ProtoMember(3, Name = @"z")]
		public float Z { get; set; }

		[global::ProtoBuf.ProtoMember(4, Name = @"w")]
		public float W { get; set; }

	}

}

#pragma warning restore CS1591, CS0612, CS3021, IDE1006

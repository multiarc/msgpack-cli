﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34011
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.ArrayBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.5.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_SimpleCollection_1_MsgPack_MessagePackObject_Serializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.SimpleCollection<MsgPack.MessagePackObject>> {
        
        private MsgPack.Serialization.MessagePackSerializer<object[]> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<object> _serializer1;
        
        private MsgPack.Serialization.MessagePackSerializer<object[][]> _serializer2;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime[]> _serializer3;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.DateTime>> _serializer4;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime[][]> _serializer5;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime> _serializer6;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.MessagePackObject[]> _serializer7;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.MessagePackObject[][]> _serializer8;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.MessagePackObject> _serializer9;
        
        public MsgPack_Serialization_SimpleCollection_1_MsgPack_MessagePackObject_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(MsgPack_Serialization_SimpleCollection_1_MsgPack_MessagePackObject_Serializer.@__Conditional((context != null), context, MsgPack.Serialization.SerializationContext.Default).CompatibilityOptions.PackerCompatibilityOptions) {
            MsgPack.Serialization.SerializationContext safeContext = MsgPack_Serialization_SimpleCollection_1_MsgPack_MessagePackObject_Serializer.@__Conditional((context != null), context, MsgPack.Serialization.SerializationContext.Default);
            this._serializer0 = safeContext.GetSerializer<object[]>();
            this._serializer1 = safeContext.GetSerializer<object>();
            this._serializer2 = safeContext.GetSerializer<object[][]>();
            this._serializer3 = safeContext.GetSerializer<System.DateTime[]>();
            this._serializer4 = safeContext.GetSerializer<System.Nullable<System.DateTime>>();
            this._serializer5 = safeContext.GetSerializer<System.DateTime[][]>();
            this._serializer6 = safeContext.GetSerializer<System.DateTime>();
            this._serializer7 = safeContext.GetSerializer<MsgPack.MessagePackObject[]>();
            this._serializer8 = safeContext.GetSerializer<MsgPack.MessagePackObject[][]>();
            this._serializer9 = safeContext.GetSerializer<MsgPack.MessagePackObject>();
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.SimpleCollection<MsgPack.MessagePackObject> objectTree) {
            packer.PackArrayHeader(objectTree.Count);
            System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject> enumerator = objectTree.GetEnumerator();
            MsgPack.MessagePackObject current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    this._serializer9.PackTo(packer, current);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        protected internal override MsgPack.Serialization.SimpleCollection<MsgPack.MessagePackObject> UnpackFromCore(MsgPack.Unpacker unpacker) {
            if ((unpacker.IsArrayHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotArrayHeader();
            }
            MsgPack.Serialization.SimpleCollection<MsgPack.MessagePackObject> collection = default(MsgPack.Serialization.SimpleCollection<MsgPack.MessagePackObject>);
            collection = new MsgPack.Serialization.SimpleCollection<MsgPack.MessagePackObject>();
            this.UnpackToCore(unpacker, collection);
            return collection;
        }
        
        protected internal override void UnpackToCore(MsgPack.Unpacker unpacker, MsgPack.Serialization.SimpleCollection<MsgPack.MessagePackObject> collection) {
            if ((unpacker.IsArrayHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotArrayHeader();
            }
            int count = default(int);
            count = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
            for (int i = 0; (i < count); i = (i + 1)) {
                MsgPack.MessagePackObject nullable = default(MsgPack.MessagePackObject);
                if ((unpacker.Read() == false)) {
                    throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                }
                if (((unpacker.IsArrayHeader == false) 
                            && (unpacker.IsMapHeader == false))) {
                    nullable = unpacker.LastReadData;
                }
                else {
                    nullable = unpacker.UnpackSubtreeData();
                }
                if ((nullable.IsNil == false)) {
                    collection.Add(nullable);
                }
                else {
                    collection.Add(nullable);
                }
            }
        }
        
        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}
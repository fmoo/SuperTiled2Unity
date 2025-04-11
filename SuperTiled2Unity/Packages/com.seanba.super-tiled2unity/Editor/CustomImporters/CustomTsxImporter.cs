namespace SuperTiled2Unity.Editor
{
    public class TsxAssetImportedArgs
    {
        public TsxAssetImporter AssetImporter { get; set; }
        public SuperTileset ImportedTileset { get; set; }
    };

    public abstract class CustomTsxImporter
    {
        // Invoked when a Tsx asset import is completed (the prefab and all other objects associated with the asset have been constructed)
        public abstract void TsxAssetImported(TsxAssetImportedArgs args);
    }
}

// Test usage of a custom importer
/*
namespace MyNamespace
{
    public class MyTsxImporter : CustomTsxImporter
    {
        public override void TsxAssetImported(TsxAssetImportedArgs args)
        {
            // Just log the name of the map
            var map = args.ImportedSuperMap;
            Debug.LogFormat("Map '{0}' has been imported.", map.name);
        }
    }

    // Use DisplayNameAttribute to control how class appears in the list
    [DisplayName("My Other Importer")]
    public class MyOtherTsxImporter : CustomTsxImporter
    {
        public override void TsxAssetImported(TsxAssetImportedArgs args)
        {
            // Just log the number of layers in our tiled map
            var map = args.ImportedSuperMap;
            var layers = map.GetComponentsInChildren<SuperLayer>();
            Debug.LogFormat("Map '{0}' has {1} layers.", map.name, layers.Length);
        }
    }

    [AutoCustomTsxImporter()]
    public class MyOrderedTsxImporter : CustomTsxImporter
    {
        public override void TsxAssetImported(TsxAssetImportedArgs args)
        {
            Debug.Log("MyOrderedTsxImporter importer");
        }
    }

    [AutoCustomTsxImporter(1)]
    public class MyOrderedTsxImporter1 : CustomTsxImporter
    {
        public override void TsxAssetImported(TsxAssetImportedArgs args)
        {
            Debug.Log("MyOrderedTsxImporter1 importer");
        }
    }

    [AutoCustomTsxImporter(2)]
    public class MyThrowingCustomImporter : CustomTsxImporter
    {
        public override void TsxAssetImported(TsxAssetImportedArgs args)
        {
            throw new CustomImporterException("This is my custom importer exception message.");
        }
    }
}
*/
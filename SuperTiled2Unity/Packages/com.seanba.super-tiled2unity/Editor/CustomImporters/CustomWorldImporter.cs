namespace SuperTiled2Unity.Editor
{
    public class WorldAssetImportedArgs
    {
        public WorldAssetImporter AssetImporter { get; set; }
        public SuperWorld ImportedSuperWorld { get; set; }
    };

    public abstract class CustomWorldImporter
    {
        // Invoked when a World asset import is completed (the prefab and all other objects associated with the asset have been constructed)
        public abstract void WorldAssetImported(WorldAssetImportedArgs args);
    }
}

// Test usage of a custom importer
/*
namespace MyNamespace
{
    public class MyTmxImporter : CustomTmxImporter
    {
        public override void TmxAssetImported(TmxAssetImportedArgs args)
        {
            // Just log the name of the map
            var map = args.ImportedSuperMap;
            Debug.LogFormat("Map '{0}' has been imported.", map.name);
        }
    }

    // Use DisplayNameAttribute to control how class appears in the list
    [DisplayName("My Other Importer")]
    public class MyOtherTmxImporter : CustomTmxImporter
    {
        public override void TmxAssetImported(TmxAssetImportedArgs args)
        {
            // Just log the number of layers in our tiled map
            var map = args.ImportedSuperMap;
            var layers = map.GetComponentsInChildren<SuperLayer>();
            Debug.LogFormat("Map '{0}' has {1} layers.", map.name, layers.Length);
        }
    }

    [AutoCustomTmxImporter()]
    public class MyOrderedTmxImporter : CustomTmxImporter
    {
        public override void TmxAssetImported(TmxAssetImportedArgs args)
        {
            Debug.Log("MyOrderedTmxImporter importer");
        }
    }

    [AutoCustomTmxImporter(1)]
    public class MyOrderedTmxImporter1 : CustomTmxImporter
    {
        public override void TmxAssetImported(TmxAssetImportedArgs args)
        {
            Debug.Log("MyOrderedTmxImporter1 importer");
        }
    }

    [AutoCustomTmxImporter(2)]
    public class MyThrowingCustomImporter : CustomTmxImporter
    {
        public override void TmxAssetImported(TmxAssetImportedArgs args)
        {
            throw new CustomImporterException("This is my custom importer exception message.");
        }
    }
}
*/
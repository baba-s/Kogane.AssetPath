using UnityEditor;

namespace Kogane
{
    public readonly struct AssetPath
    {
        public string Path { get; }

        public string DirectoryName            => System.IO.Path.GetDirectoryName( Path );
        public string Extension                => System.IO.Path.GetExtension( Path );
        public string FileName                 => System.IO.Path.GetFileName( Path );
        public string FileNameWithoutExtension => System.IO.Path.GetFileNameWithoutExtension( Path );
        public string FullPath                 => System.IO.Path.GetFullPath( Path );

        public string GUID          => AssetDatabase.AssetPathToGUID( Path );
        public bool   IsValidFolder => AssetDatabase.IsValidFolder( Path );

        public AssetPath( string assetPath )
        {
            Path = assetPath;
        }

        public override string ToString()
        {
            return Path;
        }

        public static implicit operator string( AssetPath assetPath )
        {
            return assetPath.Path;
        }

        public static implicit operator AssetPath( string assetPath )
        {
            return new AssetPath( assetPath );
        }
    }
}
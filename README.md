# Kogane Asset Path

アセットのパスに関する処理を記述しやすくする構造体

## 使用例

```cs
using Kogane;
using UnityEditor;
using UnityEngine;

public static class Test
{
    [MenuItem( "Tools/Hoge" )]
    private static void Hoge()
    {
        var assetPath = new AssetPath( "Assets/New Material.mat" );

        // 下記の記述も可能
        //AssetPath assetPath = "Assets/New Material.mat";

        Debug.Log( assetPath );
        Debug.Log( assetPath.DirectoryName );
        Debug.Log( assetPath.Extension );
        Debug.Log( assetPath.FileName );
        Debug.Log( assetPath.FileNameWithoutExtension );
        Debug.Log( assetPath.FullPath );
        Debug.Log( assetPath.GUID );
        Debug.Log( assetPath.IsValidFolder );

        // string への暗黙的なキャスト
        string str = assetPath;

        Debug.Log( str );

        // string からの暗黙的なキャスト
        assetPath = str;

        Debug.Log( assetPath );
    }
}
```

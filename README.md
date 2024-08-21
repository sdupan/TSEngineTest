# TSEngineTest
This is a test project for UnityTSEngine.

## Ussage

### Environment

1. Unity 2022.3.5f1 or above
2. Python 3.10 above

### Test

1. Enter TsProj Folder
2. Open the commond-line tool. Execute: npm install.

    ```
    npm install
    ```

3. Execute `zpublish.py`

    - 1.[merge]    ->  Merge all js files to bundle.js.
    - 2.[uglify]   ->  Merge all js files to bundle.js and use uglify tool to minify bundle.js.
    - 3.[minify]   ->  Merge all js files to bundle.js and use obfuscator tool to minify bundle.js.

    Type `1` to generate `bin\bundle.js`.

4. Startup the unity editor play mode to do testing.

### See

* [UnityTSEngine](https://github.com/sdupan/UnityTSEngine)
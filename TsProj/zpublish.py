import os
import sys
import io
import shutil

temp_path = os.path.join(os.path.dirname(__file__), "./temp")
source_map_path = os.path.join(os.path.dirname(__file__), "./temp/bundle.js.map")
bin_path = os.path.join(os.path.dirname(__file__), "./bin/bundle.js")
source_map_bin_path = os.path.join(os.path.dirname(__file__), "./bin/bundle.js.map")
asset_bundle_path = os.path.join(os.path.dirname(__file__), "../Assets/GameAssets/Src/bundle.bytes")

def gulp_cmd(cmd_str):
    fp = os.popen(r"gulp" + cmd_str, "r")
    content = fp.buffer.read().decode(encoding='utf8')
    fp.close()
    print(content)

def gulp_default():
    rm_bin()
    gulp_cmd("")

def copy_bundle():
    if os.path.exists(bin_path):
        shutil.copy(bin_path, asset_bundle_path)

    if os.path.exists(source_map_path):
        shutil.copy(source_map_path, source_map_bin_path)

def gulp_merge():
    gulp_cmd(" merge")
    copy_bundle()
    rm_temp()

def gulp_uglify():
    gulp_cmd(" uglify")
    copy_bundle()
    rm_temp()

def gulp_minify():
    gulp_cmd(" minify")
    copy_bundle()
    rm_temp()

def rm_temp():
    if os.path.exists(temp_path):
       shutil.rmtree(temp_path)

def rm_bin():
    if os.path.exists(bin_path):
        os.remove(bin_path)
        
def main_loop():
    while True:
        print("")
        print("*****************************************************************************")
        print("*\n*  Tips: Input the number")

        print("*\n*   1.[merge]   ->  Merge all js files to bundle.js")

        print("*\n*   2.[uglify]   ->  Merge all js files to bundle.js and use uglify tool to minify bundle.js")

        print("*\n*   3.[minify]   ->  Merge all js files to bundle.js and use obfuscator tool to minify bundle.js")

        print("*\n*   0.[exit]  ->  Exit")

        print("*\n*****************************************************************************")

        ctx = input("")
        if ctx == "0" or ctx == "exit" :
            print(" Bye  " )
            break
        elif ctx == "1" or ctx == "merge":
            gulp_default()
            gulp_merge()
        elif ctx == "2" or ctx == "uglify":
            gulp_default()
            gulp_uglify()
        elif ctx == "3" or ctx == "minify":
            gulp_default()
            gulp_minify()
    pass

def main():
    os.chdir(os.path.dirname(os.path.realpath(__file__)))
    os.system("mode con cols=100 lines=40")
    if sys.argv.__len__() > 1:
        if sys.argv[1] == "-merge":
            gulp_default()
            gulp_merge()
        elif sys.argv[1] == "-uglify":
            gulp_default()
            gulp_uglify()
        elif sys.argv[1] == "-minify":
            gulp_default()
            gulp_minify()
        else:
            main_loop()
    else:
        main_loop()
    
main()
var gulp = require('gulp');
var uglify = require('gulp-uglify');
var javascriptObfuscator = require('gulp-javascript-obfuscator');
var rollup = require('rollup');
var rollupTypescript = require('rollup-plugin-typescript2');

gulp.task("default", function(){
	return rollup.rollup({
		input: "./src/GameEntry.ts",
		onwarn:(waring, warn)=>{
			if(waring.code == "CIRCULAR_DEPENDENCY"){
				console.warn("warnning Circular dependency:");
				console.warn(waring);
			}
			else {
				console.warn(waring.message);
			}
		},
		plugins: [
			rollupTypescript({
				check: true,
				tsconfigOverride:{compilerOptions:{removeComments: true}},
			})
		],
	})
	.then(function (bundle) {
		bundle.write({
		  format: "cjs",
		  file: "./temp/bundle.js",
		  sourcemap: true
		});
	})
	.catch(e => {
		console.log(e.toString());
	})
})

gulp.task("merge", function(){
    return gulp.src('temp/bundle.js')
    .pipe(gulp.dest('bin'));
});

gulp.task('uglify', function() {
    return gulp.src('temp/bundle.js')
	.pipe(uglify({mangle: { toplevel: true }, compress: true}))
	.pipe(gulp.dest('bin'));
});

gulp.task('minify', function() {
    return gulp.src('temp/bundle.js')
	.pipe(javascriptObfuscator({
		compact: true,
		controlFlowFlattening: false,
		deadCodeInjection: false,
		debugProtection: true,
		debugProtectionInterval: 1,
		disableConsoleOutput: false,
		identifierNamesGenerator: 'hexadecimal',
		log: false,
		numbersToExpressions: false,
		renameGlobals: false,
		rotateStringArray: true,
		selfDefending: false,
		shuffleStringArray: true,
		simplify: true,
		splitStrings: false,
		stringArray: true,
		stringArrayEncoding: [],
		stringArrayIndexShift: true,
		stringArrayWrappersCount: 1,
		stringArrayWrappersChainedCalls: true,
		stringArrayWrappersParametersMaxCount: 2,
		stringArrayWrappersType: 'variable',
		stringArrayThreshold: 0.75,
		unicodeEscapeSequence: false
	}))
	.pipe(gulp.dest('bin'));
});
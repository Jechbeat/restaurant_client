// include plug-ins
var gulp = require('gulp');
var concat = require('gulp-concat');
var uglify = require('gulp-uglify');
var del = require('del');

var config = {
    //Include all js files but exclude any min.js files
    src: [     "scripts/jquery-2.1.1.js",
    "scripts/angular.js",
    "scripts/angular-filter.min.js",
    "scripts/angular-animate.js",
    "scripts/angular-route.js",
    "scripts/angular-sanitize.js",
    "scripts/bootstrap.js",
    "scripts/toastr.js",
    "scripts/moment.js",
    "scripts/angular-bootstrap-select.js",
    //"scripts/textAngular-sanitize.js",
    //"scripts/textAngular.js",
    //"scripts/textAngularSetup.js",
    "scripts/ui-bootstrap-tpls-0.10.0.js",
    "scripts/spin.js",
    "scripts/angular-tree-control.js",
    "scripts/textAngular-rangy.min.js",
    "scripts/textAngular-sanitize.min.js",
    "scripts/textAngular.min.js",
    "bower_components/angular-dir-pagination/dirPagination.js",    
    'app/**/*.js', '!app/**/*.min.js',
    'Content/js/*.js'

    ]
}

//delete the output file(s)
gulp.task('clean', function () {
    //del is an async function and not a gulp plugin (just standard nodejs)
    //It returns a promise, so make sure you return that from this task function
    //  so gulp knows when the delete is complete
    return del(['app/all.min.js']);
});

// Combine and minify all files from the app folder
// This tasks depends on the clean task which means gulp will ensure that the 
// Clean task is completed before running the scripts task.
gulp.task('scripts', ['clean'], function () {

    return gulp.src(config.src)
      .pipe(uglify())
      .pipe(concat('all.min.js'))
      .pipe(gulp.dest('app/'));
});

//Set a default tasks
gulp.task('default', ['scripts'], function () { });

gulp.task('watch', function () {
    return gulp.watch(config.src, ['scripts']);
});
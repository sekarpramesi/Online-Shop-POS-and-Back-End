let mix = require('laravel-mix');

/*
 |--------------------------------------------------------------------------
 | Mix Asset Management
 |--------------------------------------------------------------------------
 |
 | Mix provides a clean, fluent API for defining some Webpack build steps
 | for your Laravel application. By default, we are compiling the Sass
 | file for the application as well as bundling up all the JS files.
 |
 */

mix.react('resources/assets/js/app.js', 'public/js','public/js/vendor')
   .sass('resources/assets/sass/app.scss', 'public/css')
   .styles([
    'resources/assets/css/vendor/font-awesome.min.css',
    'resources/assets/css/vendor/nouislider.min.css',
    'resources/assets/css/vendor/bootstrap.min.css',
    'resources/assets/css/vendor/slick-theme.css',
    'resources/assets/css/vendor/slick.css',
    'resources/assets/css/vendor/style.css',
], 'public/css/all.css');
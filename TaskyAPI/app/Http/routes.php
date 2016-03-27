<?php

/*
|--------------------------------------------------------------------------
| Application Routes
|--------------------------------------------------------------------------
|
| Here is where you can register all of the routes for an application.
| It's a breeze. Simply tell Laravel the URIs it should respond to
| and give it the controller to call when that URI is requested.
|
*/


Route::get('users','UserController@index');

//
//Route::group(['middleware' => ['web']], function () {
//
//    Route::get('/', function () {
//        return view('welcome');
//    });
//
//    Route::get('/names', function () {
//        return [1 => 'john',
//            2 => 'Mary',
//            3 => 'Steven'];
//    });
//
//    Route::get('/authtest', ['before' => 'auth.basic', function () {
//        return 'hello';
//    }]);
//}

   // Route::get('date','UserController@currentdate');

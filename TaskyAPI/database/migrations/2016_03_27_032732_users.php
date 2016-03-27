<?php

use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class Users extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {

        Schema::create('users', function(Blueprint $table){
            $table->increments('id');
            $table->string('firstname');
            $table->string('username')->unique();
            $table->string('lastname');
            $table->string('address');
            $table->integer('zipcode');
            $table->string('city');
            $table->string('state');
            $table->integer('phonenumber');
            $table->integer('points');
            $table->string('email')->unique();
            $table->timestamps();
            $table->string('password');
        });

    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::drop('users');
    }
}

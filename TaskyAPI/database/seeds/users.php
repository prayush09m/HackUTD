<?php

use Illuminate\Database\Seeder;



 class users extends Seeder{

     public function run(){
         DB::table('users')->insert([
          'firstname' => 'prayush',
             'username' => 'prayush09',
             'lastname' => 'pokharel',
             'address' => '1212 hooks Dr Apt 5',
             'zipcode' => 70401,
             'city' => 'hammond',
             'state' => 'Louisiana',
             'phonenumber' => '8178517506',
             'points' => 100,
             'email' => 'prayush.pokharel@selu.edu',
             'password'=>'HackMe'
         ]);
     }



 }
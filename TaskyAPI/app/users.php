<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class users extends Model
{
    protected $tables = 'users';

    protected $fillable = [
        'firstname',
        'lastname',
        'username',
        'email',
        'phonenumber',
        'password',
        'address',
        'points',
        'state',
        'city',
        'zipcode',

    ];

    protected $hidden = [
        'phonenumber','password'];

}

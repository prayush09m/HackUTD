<?php

use Illuminate\Database\Seeder;

class tasks extends Seeder
{

    public function run()
    {
        DB::table('tasks')->insert([
            'name' => 'mopping',
            'location' => 'dallas',
            'duration' => 50,
            'pointsassigned' => 30,
            'jobdescription' => 'To mop your ass off',
            'completiontime' => 'timeistoday'

        ]);
    }
}

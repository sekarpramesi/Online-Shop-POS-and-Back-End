<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Barang extends Model
{
    protected $table = 'Barang';
    protected $primaryKey = 'ID_BARANG';
    protected $connection = 'oracle';

}

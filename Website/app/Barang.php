<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Barang extends Model
{
    protected $table= 'BARANG';
    protected $primaryKey = 'ID_BARANG';
    protected $connection = 'oracle';
}

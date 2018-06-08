<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use DB;

class HomeController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $laptop = DB::select('select * from barang where id_kategori=? and rownum<5',['K0001']);
        $kamera = DB::select('select * from barang where id_kategori=? and rownum<5',['K0002']);
        $handphone = DB::select('select * from barang where id_kategori=? and rownum<5',['K0003']);
        $tablet = DB::select('select * from barang where id_kategori=? and rownum<5',['K0004']);
        $powerbank = DB::select('select * from barang where id_kategori=? and rownum<5',['K0005']);
        return view('home.index',['laptop'=>$laptop,'kamera'=>$kamera,'handphone'=>$handphone,
            'tablet'=>$tablet,'powerbank'=>$powerbank]);
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        //
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        //
    }
}

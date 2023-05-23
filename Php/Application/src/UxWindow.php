<?php
namespace Php\Application;

use Godot\GD;
use Godot\Node2D;

class UxWindow extends Node2D {
    
    public function UxReady() {
        GD::Print(__CLASS__);
    }

}
#!/usr/bin/env groovy

node{
    
    stage("Cleanup"){
        cleanWs()
    }
    
    branch="master"
    org="adchurch"
    release_version=6
    
    stage("build"){
        
        build_list = [
            [ts_version: '2014', vs_year_version: '2015', x64_build_flag: false, sp_version: 1],
            [ts_version: '2014', vs_year_version: '2015', x64_build_flag: true, sp_version: 1],
            [ts_version: '2014', vs_year_version: '2016', x64_build_flag: false, sp_version: 0],
            [ts_version: '2014', vs_year_version: '2016', x64_build_flag: true, sp_version: 0],
            [ts_version: '2014', vs_year_version: '2017', x64_build_flag: false, sp_version: 0],
            [ts_version: '2014', vs_year_version: '2017', x64_build_flag: true, sp_version: 0],
            [ts_version: '2016', vs_year_version: '2015', x64_build_flag: false, sp_version: 1],
            [ts_version: '2016', vs_year_version: '2015', x64_build_flag: true, sp_version: 1],
            [ts_version: '2016', vs_year_version: '2016', x64_build_flag: false, sp_version: 0],
            [ts_version: '2016', vs_year_version: '2016', x64_build_flag: true, sp_version: 0],
            [ts_version: '2016', vs_year_version: '2017', x64_build_flag: false, sp_version: 0],
            [ts_version: '2016', vs_year_version: '2017', x64_build_flag: true, sp_version: 0]]
             
        build_list.each { build_map ->
            veristandStepsPipeline(branch, org, build_map.vs_year_version, build_map.sp_version, build_map.ts_version, build_map.x64_build_flag, release_version)
        }
            
    }
}
    
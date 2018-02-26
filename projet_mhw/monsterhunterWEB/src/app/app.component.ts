import {Component, OnInit} from '@angular/core';
import {Router} from '@angular/router';
import {TranslateService} from '@ngx-translate/core';
import {forEach} from '@angular/router/src/utils/collection';
declare var $: any;

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  constructor(private router: Router, private translate: TranslateService) {}

  search: string;
  ngOnInit() {
    this.translate.setDefaultLang('fr');
  }
  changeFR() {
    this.translate.use('fr');
  }
  changeEN() {
    this.translate.use('en');
  }
  home() {
    this.router.navigate(['/']);
    console.log(this.search);
  }
}

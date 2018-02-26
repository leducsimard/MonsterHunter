import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable()
export class WebApiService {
  constructor(private http: HttpClient) {}

  private static makeApiUrl(endpoint: string): string {
    let loc = location.protocol + '//' + location.hostname + ':2430/';
    return loc + endpoint;
  }
}
